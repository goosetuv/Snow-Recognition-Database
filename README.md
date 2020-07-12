<a href="http://github.com/goosetuv/snow-recognition-database"><img src="/images/srd-logo.png" title="Snow Recognition Database" alt="SRD Logo"></a>

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

Windows Application that allows you to view the Unassigned and Assigned Software from Snow License Manager and Snow Inventory.

---

## Screenshot
<a href="http://github.com/goosetuv/snow-recognition-database"><img src="/images/screenshot-2.0.PNG" title="Snow Recognition Database 2.0" alt="SRD Screenshot 2.0"></a>

## Installation

Download the latest release and run!

## Features

- Direct connect to SQL Server
- Fast Export of Data to CSV or XLSX
- Portable
- Viewing of all applications in the SRS database as well as their rules
- Viewing of all applications not in the SRS database
- Default column visibility options
- Supported on Snow License Manager 8 and Snow License Manager 9


## Usage

- Open SRD.exe
- Create a database connection to your Snow SQL Server

## Known Issue
### Execution Timeout Expired
Execution Timeout is related to the timeout period between the application and Microsoft SQL Server. This issue is prominent in Snow Recognition Database 2.0 due to the additional search features such as Unassigned Applications.

This issue will likely be found on a case by case basis and does not affect all users, it is prominent on users with large vFilterSoftware tables in the Snow Inventory database.

#### Fix
When inside of your connection, click on File > Application Settings > Database and increase the Command Timeout until the error no longer appears. The more data you have in the system, the higher the timeout will need to be.

## Contributing
Happy for anyone to make a pull request to assist in making the application better.
