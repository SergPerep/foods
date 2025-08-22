# Foods

Promt to generate data via LLM "Generate insert queries of 100 food items. Headers: name (string), protein (int), carbs (int), fat (int), alcohol (int), and fiber (int). All int values in grams per 100 g of food item. The name of the table is foods."

Uses [Npgsql.EntityFrameworkCore.PostgreSQL](https://www.npgsql.org/efcore/index.html?tabs=onconfiguring) to communicate to DB


## Env variables

`POSTGRESQLCONNSTR_PostgresConnection`