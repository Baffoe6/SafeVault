-- database.sql
CREATE TABLE Users (
    UserID SERIAL PRIMARY KEY,
    Username VARCHAR(100),
    Email VARCHAR(100)
);
