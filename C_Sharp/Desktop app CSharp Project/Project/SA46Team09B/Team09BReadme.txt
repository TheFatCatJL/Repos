INTRODUCTION
------------

The Sport Facility Booking System designed by Team 9B is to provide booking function for the sport facilities administered by NUS Sports Union. The design philosophy is to achieve user desired query in 3 clicks or less, and modularisation allows function system expansions according to business needs and changes.


REQUIREMENTS
------------

This system requires .Net runtime libraries, and also unrestricted access (preferred) for installation of database in MSSQL server, as well as MSSQL Server Management Studio.

 * .NET Framework (https://www.microsoft.com/net/download/Windows/run) 
 * MSSQL (https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

RECOMMENDED SOFTWARE
-------------------

 * Crystal Reports (http://www.crystalreports.com/crvs/confirm/)

INSTALLATION
------------
 
 * Install first the database file SA46Team09B.bak to MS SQL Server Management Studio

 * Unzip the SA46Team09B ESNET Project.zip into accessible directory (full user rights) 

 
CONFIGURATION
-------------

The module has no menu or modifiable settings. 


TROUBLESHOOTING
---------------

 * If the receiving error messages like "Connection failure".

   - Check your username and password (if not using windows authentication)
   - Check your SQL connection using SQL Server 2017 Configuration Manager
   - Mac users running Parallels are known to experiencing runtime error when trying to access the report section (maninly powered by crystal reports.

FAQ
---

Q: There is only limited dates that can be choosen in the date time picker, is that normal?

A: Yes, this is the intended behavior for this prototype. This is to limit user selection of booking dates with accordance to current business scope (being up to 7 days in advance booking).

CURRENT KNOWN ISSUES
--------------------
 * Auto purging of Availiability list (such that there will be no expired records) is on a day basis, therefore, records of the expired timeslot will still be recorded for the same day.
 * Login module not implemented (current scope is that the system is for limited users in a terminal setting in an enclosed environment)
 * Database performance is tied to local machine (in this case, the terminal which the system will be installed)
 * Booking facilities per activity is limited to 6 venues (Current scope is 4, will be address in next version after discussion with user)
 * Booking time records and some Transaction records in table are in the 0:00:00 format (will be standardised to dd mm yy in the next version)
 * Tables data fields are not finalised (need more business requirement output) and therefore, also not normalised. Currently only at 1NF.
 * Tables may currently have invalid data due to the process of testing. These data are not purged at the moment for the sake of further testing. However, the prototype is producing valid data as per the current business context.

CODE MAINTAINERS
-----------

Current maintainers:
 * Jason Lim (Jason) - https://github.com/TheFatCatJL
 * Janelle Wang (XB) - https://github.com/janellesque
 * Noel-Noel Han (Noel-Noel) - https://github.com/DnNoel
 * Subash Machavel (Subash) - https://github.com/SubashM

This project has been guided by:
Lecturers of Institute of Systems Science