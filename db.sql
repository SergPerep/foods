-- Create tables --
CREATE TABLE foods (
    id BIGSERIAL NOT NULL PRIMARY KEY,
    name varchar(100) NOT NULL,
    protein SMALLINT NOT NULL,
    carbs SMALLINT NOT NULL,
    fat SMALLINT NOT NULL,
    fiber SMALLINT NOT NULL,
    alcohol SMALLINT NOT NULL
);

-- Add records --

INSERT INTO foods (name, protein, carbs, fat, fiber, alcohol)
VALUES ('Whole milk', 21, 31, 48, 0, 0);

INSERT INTO foods (name, protein, carbs, fat, fiber, alcohol)
VALUES ('Apple', 0, 14, 0, 0, 0);