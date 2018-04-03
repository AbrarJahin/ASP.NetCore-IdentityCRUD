# Migration Detail can be found [here](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/#creating-the-database).

In sort-
--------

To add a new table in a database-
---------------------------------

1. Create a new DB Model Class in `Models` folder.
2. Add the model in DB Context - `ApplicationDbContext.cs`
3. Then add DB migration command-

- InPowershell

	Add-Migration <MigrationFileName>

- or in Console

	dotnet ef migrations add <MigrationFileName>

4. Then update DB migration command (optional)-

- InPowershell

	Update-Database

- or in Console

	dotnet ef migrations update

* To remove migration-

- InPowershell

	Remove-Migration <MigrationFileName>

Or to remove all migration-

	Remove-Migration

Configure minification of JS and CSS files can be found [here](https://go.microsoft.com/fwlink/?LinkId=808241).
