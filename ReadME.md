--run app on dev

a] Edit Web.config - connectionString according to your db server name

b] In package Manager console: Update-database - to create database with initial seed data

c] Run project in MS Visual Studio: ctrl + F5



--Todos

*create order is ugly coded.. - has to be refactored 
- complex data types binding?
- validation?

*update order not implemented yet


-----remarks

--older EF install

In package Manager console I had to:

0] In connection string is only 1! backslash ..(localdb)\MSSQLLocalDB...

1] Enable-Migrations

2] Add-migration Init

3] Update-database