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

INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Almonds', 21, 22, 50, 0, 12);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Apple', 0, 14, 0, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Avocado', 2, 9, 15, 0, 7);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Banana', 1, 23, 0, 0, 3);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Beef (ground)', 26, 0, 20, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Beer', 0, 3, 0, 4, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Black beans', 9, 23, 0, 0, 8);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Blueberries', 1, 14, 0, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Bread (white)', 9, 49, 3, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Broccoli', 3, 7, 0, 0, 3);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Brown rice', 2, 23, 1, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Butter', 1, 0, 81, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Cabbage', 1, 6, 0, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Carrot', 1, 10, 0, 0, 3);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Cashews', 18, 30, 44, 0, 3);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Cauliflower', 2, 5, 0, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Celery', 1, 3, 0, 0, 1);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Cheddar cheese', 25, 1, 33, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Chicken breast', 31, 0, 3, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Chickpeas', 19, 27, 6, 0, 8);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Chocolate (dark)', 7, 46, 43, 0, 10);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Coconut', 3, 15, 33, 0, 9);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Cod (raw)', 18, 0, 1, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Corn', 3, 19, 1, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Cucumber', 1, 4, 0, 0, 1);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Dates', 2, 75, 0, 0, 8);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Egg (whole)', 13, 1, 11, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Eggplant', 1, 6, 0, 0, 3);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Feta cheese', 14, 4, 21, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Flaxseeds', 18, 29, 42, 0, 27);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Grapes', 1, 17, 0, 0, 1);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Green peas', 5, 14, 0, 0, 5);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Ham', 20, 2, 9, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Honey', 0, 82, 0, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Kale', 3, 9, 1, 0, 4);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Kiwi', 1, 15, 1, 0, 3);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Lamb', 25, 0, 20, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Lentils', 9, 20, 0, 0, 8);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Lettuce', 1, 3, 0, 0, 1);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Mango', 1, 15, 0, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Milk (whole)', 3, 5, 4, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Mozzarella', 22, 2, 22, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Mushrooms', 3, 3, 0, 0, 1);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Oatmeal', 13, 68, 7, 0, 10);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Olive oil', 0, 0, 100, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Onion', 1, 9, 0, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Orange', 1, 12, 0, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Papaya', 1, 11, 0, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Parmesan', 38, 4, 27, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Peanut butter', 25, 20, 50, 0, 6);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Peanuts', 26, 16, 49, 0, 8);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Pear', 1, 15, 0, 0, 3);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Pineapple', 1, 13, 0, 0, 1);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Pistachios', 20, 28, 45, 0, 10);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Potato', 2, 17, 0, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Pumpkin seeds', 19, 54, 19, 0, 6);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Quinoa', 14, 64, 6, 0, 7);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Raspberry', 1, 12, 1, 0, 6);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Rice (white)', 2, 28, 0, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Salmon', 20, 0, 13, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Shrimp', 24, 0, 0, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Spinach', 3, 4, 0, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Strawberry', 1, 8, 0, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Sweet potato', 2, 20, 0, 0, 3);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Swiss cheese', 27, 1, 28, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Tofu', 8, 2, 5, 0, 1);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Tomato', 1, 4, 0, 0, 1);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Tuna', 30, 0, 1, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Turkey', 29, 0, 7, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Walnuts', 15, 14, 65, 0, 7);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Watermelon', 1, 8, 0, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Wheat bread', 13, 41, 2, 0, 7);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('White fish', 18, 0, 1, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Yogurt (plain)', 10, 4, 5, 0, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Zucchini', 1, 3, 0, 0, 1);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Cider', 0, 5, 0, 4, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Red wine', 0, 0, 0, 12, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('White wine', 0, 0, 0, 11, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Whiskey', 0, 0, 0, 40, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Vodka', 0, 0, 0, 40, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Rum', 0, 0, 0, 40, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Tequila', 0, 0, 0, 40, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Gin', 0, 0, 0, 40, 0);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Acorn squash', 1, 15, 0, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Artichoke', 3, 11, 0, 0, 5);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Asparagus', 2, 4, 0, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Basil', 3, 2, 0, 0, 1);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Blackberries', 2, 10, 1, 0, 5);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Brussels sprouts', 4, 9, 0, 0, 4);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Cherries', 1, 16, 0, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Chia seeds', 17, 42, 31, 0, 34);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Cilantro', 2, 3, 0, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Edamame', 12, 9, 5, 0, 5);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Figs (dried)', 3, 64, 1, 0, 9);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Ginger root', 2, 18, 0, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Gooseberries', 1, 10, 0, 0, 4);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Guava', 2, 14, 1, 0, 5);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Hazelnuts', 14, 17, 61, 0, 10);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Jalapeno', 1, 7, 0, 0, 2);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Kiwano (horned melon)', 1, 7, 0, 0, 3);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Leeks', 2, 14, 0, 0, 1);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Lima beans', 7, 20, 0, 0, 5);
INSERT INTO foods (name, protein, carbs, fat, alcohol, fiber) VALUES ('Lychee', 1, 17, 0, 0, 1);