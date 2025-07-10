![Oracle Logo](https://raw.githubusercontent.com/oracle/dotnet-db-samples/master/images/oracle-nuget.png) 
# Oracle.ManagedDataAccess.Core 23.8.0
Release Notes for Oracle Data Provider for .NET Core NuGet Package

March 2025

Oracle Data Provider for .NET (ODP.NET) Core features optimized ADO.NET data access to the Oracle database for .NET (Core) runtime. ODP.NET allows developers to take advantage of advanced Oracle database functionality, including AI vectors, Real Application Clusters, Application Continuity, JSON Relational Duality, and Fast Connection Failover. 

This document provides information that supplements the [Oracle Data Provider for .NET (ODP.NET) documentation](https://docs.oracle.com/en/database/oracle/oracle-database/23/odpnt/index.html).

## Oracle .NET Links
* [Oracle .NET Home Page](https://www.oracle.com/database/technologies/appdev/dotnet.html)
* [GitHub - Sample Code](https://github.com/oracle/dotnet-db-samples)
* [ODP.NET Discussion Forum](https://forums.oracle.com/ords/apexds/domain/dev-community/category/odp-dot-net)
* [YouTube](https://www.youtube.com/user/OracleDOTNETTeam)
* [X (Twitter)](https://twitter.com/oracledotnet)
* [Email Newsletter Sign Up](https://go.oracle.com/LP=28277?elqCampaignId=124071&nsl=onetdev)

## New Features
* AI: Oracle Sparse Vector and Dense Vector Data Types
* OracleDataSource (Oracle DbDataSource)
* SQL Injection Protection with OracleDBMSAssert
* Bulk Copy Boolean Data Type Support
* Password-Protected Wallet (PKCS#12) Support
* Password-Protected Wallet (PKCS#12) and Auto-Login Wallet (SSO) Support in Secure External Password Store (SEPS)
* Automatic Connection Recovery

## Bug Fixes since Oracle.ManagedDataAccess.Core 23.7.0
* Bug 37753231 - FLEX DENSE VECTOR COLUMNS HAVE INCONSISTENT BEHAVIOR IN ORACLEDATAREADER.GETFIELDTYPE(), ORACLEDATAREADER.GETVALUE(), AND ORACLEDATAADAPTER.FILL()
* Bug 37705687 - WHEN ORACLEAQQUEUE.LISTEN() TIMES OUT, IT SHOULD RETURN NULL, RATHER THAN AN EXCEPTION THROWN FOR ORA-25254.
* Bug 37571978 - OPTIMIZE ORACLEDECIMAL.TOSTRING() AND ORACLEDATAREADER.GETSTRING() FOR NUMBER COLUMNS : HIGHER THROUGHPUT AND LOWER MEMORY USAGE
* Bug 37563784 - OPTIMIZE TOSTRING() METHOD FOR ORACLEDATE : HIGHER THROUGHPUT AND LOWER MEMORY USAGE
* Bug 37525372 - SYSTEM.ARGUMENTOUTOFRANGEEXCEPTION : INDEX WAS OUT OF RANGE, IS OBSERVED WHEN CLOB COLUMNS ARE IN THE RESULT SET AND FETCHSIZE IS SET
* Bug 37517481 - PERFORMANCE ISSUE WHEN ONLY NULLS ARE IN THE RESULT SET
* Bug 37495128 - ORA-50232: NETWORK TRANSPORT: TCP TRANSPORT ADDRESS CONNECT FAILURE DUE TO CACHED, STALE IP ADDRESS
* Bug 37490193 - ADD ORACLEBULKCOPYOPTIONS.ENFORCEINDEXCHECKS ENUMERATION VALUE TO ENABLE/DISABLE INDEX CHECKS DURING BULKCOPY
* Bug 37365816 - SUPPRESSGETDECIMALINVALIDCASTEXCEPTION WITH UDT NUMERIC PROPERTIES GENERATE ARITHMETIC OPERATION RESULTED IN AN OVERFLOW ERROR
* Bug 37160309 - TTC ERROR IS ENCOUNTERED WHEN OPENTELEMETRY ENABLESQLIDTRACING IS ENABLED AND COMMAND EXECUTION RETURNS REF CURSOR
* Bug 36759038 - APOSTROPHES IN CONNECT DESCRIPTOR USER VARIABLE CAUSE ORA-00303: SYNTAX ERROR IN NAME-VALUE STRING 

 Copyright (c) 2024, 2025, Oracle and/or its affiliates. 
