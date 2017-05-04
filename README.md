# PepperJack

Example project using Dapper and the MySQL .NET Connector from .NET Core

## Preconditions

- .NET Core
- MariaDB/MySQL (seed the `employees` database using [this repo](https://github.com/datacharmer/test_db))
- A local `test`/`pass` user in the MariaDB/MySQL database with access to the `employees` data.

## How to run

```shell
$ dotnet run
```

You should now be able to get some data:

```shell
$ curl http://localhost:5000/api/employees
```

If you want to make it be readable, pipe it via `jq` since the JSON being returned is by default not pretty-printed (optimized for machines, not humans):

```shell
$ curl http://localhost:5000/api/employees | jq .
```
