	-- المالك الرئيسي للقاعدة
	CREATE USER prison_dba IDENTIFIED BY admin
	DEFAULT TABLESPACE users
	TEMPORARY TABLESPACE temp
	QUOTA UNLIMITED ON users;
	GRANT CONNECT, RESOURCE, CREATE VIEW TO prison_dba;
	GRANT DBA TO prison_dba WITH ADMIN OPTION;
	
	
-- جميع جداول المشروع --{

		-- جدول الأقسام:
	-- 1. section --
		-- الجدول:
	-- section(snumber,sname)
	CREATE TABLE section(
		snumber number primary key,
		sname varchar(25) NOT NULL unique
	);
		-- تعميم الجدول لجميع المستخدمين:
	CREATE OR REPLACE PUBLIC SYNONYM section for prison_dba.section;



		-- جدول ألزنزانات:
	-- 2. cell --
	-- cell(cnumber,csize,snumber)
		-- الجدول:
	CREATE TABLE cell(
		cnumber number primary key,
		csize NUMBER NOT NULL CHECK (csize IN (1, 2, 3, 4)),
		snumber number,
		CONSTRAINT fk_section_cell FOREIGN KEY (snumber) REFERENCES section (snumber) ON DELETE CASCADE
	);
		-- تعميم الجدول لجميع المستخدمين:
	CREATE OR REPLACE PUBLIC SYNONYM cell for prison_dba.cell;



		-- جدول الجنود:
	-- 3. guard --
	-- guard(id, fname, lname, salary, section_number) VALUES (guard_seq.NEXTVAL, 'Jane', 'Smith', 102);
		-- الجدول:
	CREATE TABLE guard(
		id number primary key,
		fname varchar(15) not null,
		lname varchar(15) not null,
		salary number(6) DEFAULT 1000,
		age NUMBER,
		added_time DATE DEFAULT SYSDATE,
		section_number number,
		CONSTRAINT fk_section_guard FOREIGN KEY (section_number) REFERENCES section (snumber) ON DELETE SET null
	);
	CREATE SEQUENCE guard_seq 
		MINVALUE 1
		START WITH 1
		INCREMENT BY 1
		NOCACHE;
		-- تعميم الجدول لجميع المستخدمين:
	CREATE OR REPLACE PUBLIC SYNONYM guard for prison_dba.guard;



		--جدول المساجين:
	-- prisoner --
	--	prisoner(id, fname, lname, cell_number, sentence, added_time) VALUES (prisoner_seq.NEXTVAL, 'Jane', 'Smith', 102);
		-- الجدول:
	CREATE TABLE prisoner (	
		id NUMBER PRIMARY KEY,
		fname VARCHAR2(15) NOT NULL,
		lname VARCHAR2(15) NOT NULL,
		cell_number NUMBER DEFAULT NULL,
		sentence VARCHAR2(25) DEFAULT 'Five Years',
		added_time DATE DEFAULT SYSDATE,
		CONSTRAINT fk_cell_prisoner FOREIGN KEY (cell_number) REFERENCES cell (cnumber) ON DELETE SET NULL
	);
	CREATE SEQUENCE prisoner_seq 
		MINVALUE 1
		START WITH 1
		INCREMENT BY 1
		NOCACHE;
		-- تعميم الجدول لجميع المستخدمين:
	CREATE OR REPLACE PUBLIC SYNONYM prisoner for prison_dba.prisoner;



		--جدول الوظائف:
	-- job --
	--  job(jnumber, salary, name)
		-- الجدول:
	CREATE table job( 
		jnumber number primary key,
		salary number not null,
		name varchar(25) not null unique
	);
		-- تعميم الجدول لجميع المستخدمين:
	CREATE OR REPLACE PUBLIC SYNONYM job for prison_dba.job;
	
	--CREATE SEQUENCE job_seq 
	--	MINVALUE 1
	--	START WITH 1
	--	INCREMENT BY 1
	--	NOCACHE;


		--جدول السجين ووظيفته (جدول وسيط بين السجن والزظائف
	-- prisoner_job --
	--  prisoner_job(prisoner_id, job_number)
	CREATE TABLE prisoner_job (
		prisoner_id NUMBER,
		job_number NUMBER,
		CONSTRAINT fk_prisoner FOREIGN KEY (prisoner_id) REFERENCES prisoner (id) ON DELETE CASCADE,
		CONSTRAINT fk_job FOREIGN KEY (job_number) REFERENCES job (jnumber) ON DELETE CASCADE,
		CONSTRAINT pk_prisoner_job PRIMARY KEY (prisoner_id, job_number)
	);
		-- تعميم الجدول لجميع المستخدمين:
	CREATE OR REPLACE PUBLIC SYNONYM prisoner_job for prison_dba.prisoner_job;



		-- جدول المستخدمين:
	-- USER --
	-- users(username)
		-- الجدول:
	CREATE TABLE users ( 
		username VARCHAR2(31) NOT NULL UNIQUE,
		time_added DATE DEFAULT SYSDATE
	);
		-- تعميم الجدول لجميع المستخدمين:
	CREATE OR REPLACE PUBLIC SYNONYM users for prison_dba.users;




		-- جدول السجناء القدماء (الذين تم حذفهم من جدول السجناء):
	--old prisoners --
	CREATE TABLE past_prisoner(
		id NUMBER PRIMARY KEY,
		fname VARCHAR2(15) NOT NULL,
		lname VARCHAR2(15) NOT NULL,
		sentence VARCHAR2(25),
		added_time DATE,
		leave_time DATE DEFAULT SYSDATE
	);
		-- تعميم الجدول لجميع المستخدمين:
	CREATE OR REPLACE PUBLIC SYNONYM past_prisoner for prison_dba.past_prisoner;
	
	CREATE OR REPLACE TRIGGER prisoner_archive_trigger
	AFTER DELETE ON prisoner
	FOR EACH ROW
	BEGIN
		INSERT INTO past_prisoner (id, fname, lname, sentence, added_time, leave_time)
		VALUES (:OLD.id ,:OLD.fname ,:OLD.lname ,:OLD.sentence ,:OLD.added_time ,SYSDATE);
	END;
	/
	


		-- جدول الجنود القدماء (الذين تم حذفهم من جدول الجنود):
	--old guards --
	CREATE TABLE past_guard(
		id NUMBER PRIMARY KEY,
		fname VARCHAR2(15) NOT NULL,
		lname VARCHAR2(15) NOT NULL,
		added_time DATE,
		leave_time DATE	DEFAULT SYSDATE
	);
		-- تعميم الجدول لجميع المستخدمين:
	CREATE OR REPLACE PUBLIC SYNONYM past_guard for prison_dba.past_guard;
	CREATE OR REPLACE TRIGGER guard_archive_trigger
	AFTER DELETE ON guard
	FOR EACH ROW
	BEGIN
		INSERT INTO past_guard (id, fname, lname, added_time, leave_time)
		VALUES (:OLD.id, :OLD.fname, :OLD.lname, :OLD.added_time, SYSDATE);
	END;
	/
	
-- END TABLES --} --نهاية الجداول




--- جميع الادوار وصلاحيات الادوار في قاعدة البيانات:
-- START ROLES --{
	
	-- prison_admin 
	CREATE role prison_admin;
	GRANT dba to prison_admin;
	
	-- prison_HR 
		-- يمكنه مشاهدة الجنود + المساجين + الوظائف ويمكنه اضافة حقول الى جدول السجين_الوظيفة وتعديل رواتب الجنود
	CREATE role prison_HR;
	GRANT SELECT ON guard TO prison_HR;
	GRANT SELECT ON prisoner TO prison_HR;
	GRANT SELECT ON job TO prison_HR;
	GRANT SELECT, INSERT, UPDATE, DELETE ON prisoner_job TO prison_HR;
	GRANT UPDATE (salary) ON guard TO prison_HR;	
	GRANT SELECT ON past_guard TO prison_HR;
	GRANT SELECT ON past_prisoner TO prison_HR;

	
	-- viewer_prisoner
		--يمكنه مشاهدة المساجين والوظائف فقط
	CREATE role viewer_prisoner;
	GRANT SELECT ON prisoner TO viewer_prisoner;
	GRANT SELECT ON job TO viewer_prisoner;
	
	-- viewer_guard
		--يمكنه مشاهدة كل شيئ عدا جدول الجنود
	CREATE role viewer_guard;
	GRANT SELECT ON prisoner TO viewer_guard;
	GRANT SELECT ON section TO viewer_guard;
	GRANT SELECT ON job TO viewer_guard;
	GRANT SELECT ON cell TO viewer_guard;
	GRANT SELECT ON past_guard TO viewer_guard;
	GRANT SELECT ON past_guard TO viewer_guard;
	GRANT SELECT ON past_prisoner TO viewer_guard;

	
	-- منح صلاحية التسجيل في القاعدة لجميع الأدوار
	GRANT CREATE SESSION TO viewer_prisoner, viewer_guard, prison_HR, prison_admin;
	-- END ROLES --}
