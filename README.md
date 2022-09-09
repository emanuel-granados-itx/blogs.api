# blogs.api
This is a testing Web API built in .NET 6 and connecting to a PostgreSQL database running in Docker containers.

Tu run the app just need to open a terminal, navigate to mydockerapi directory and run:

docker-compose build
 
Once the images are downloaded and built, run:

docker-compose up

For now, the Seed operation is not working, so you need to connect to the PostgreSQL instance in your container and run the SQL code inside the seed.sql file. That creates the blog table and insert some recrods so you can query them from Swagger.

Next step will be adding Azure B2C authentication.
