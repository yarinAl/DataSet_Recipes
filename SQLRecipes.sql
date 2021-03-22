CREATE DATABASE dbrecipes COLLATE hebrew_ci_as

go

USE dbrecipes

go

-- Drop Table TBRecipes
CREATE TABLE tbrecipes
  (
     recipe_id       INT IDENTITY,
     recipe_name     NVARCHAR(50),
     recipe_time     NVARCHAR(50),
     recipe_type     NVARCHAR(20),
     recipe_category NVARCHAR(50)
     CONSTRAINT pk_recipes PRIMARY KEY (recipe_id)
  )

go

CREATE PROC Insertion @Recipe_Name     NVARCHAR(50),
                      @Recipe_Time     NVARCHAR(50),
                      @Recipe_Type     NVARCHAR(20),
                      @Recipe_Category NVARCHAR(50)
AS
    INSERT INTO tbrecipes
                (recipe_name,
                 recipe_time,
                 recipe_type,
                 recipe_category)
    VALUES      (@Recipe_Name,
                 @Recipe_Time,
                 @Recipe_Type,
                 @Recipe_Category)

go

CREATE PROCEDURE RecipeUpdate @Recipe_Id       NVARCHAR(50),
                              @Recipe_Name     NVARCHAR(50),
                              @Recipe_Time     NVARCHAR(50),
                              @Recipe_Type     NVARCHAR(50),
                              @Recipe_Category NVARCHAR(50)
AS
  BEGIN
      UPDATE tbrecipes
      SET    recipe_name = @Recipe_Name,
             recipe_time = @Recipe_Time,
             recipe_type = @Recipe_Type,
             recipe_category = @Recipe_Category
      WHERE  recipe_id = @Recipe_Id
  END

go

alter PROCEDURE RecipeDelete @Recipe_Id INT
AS
  BEGIN
      DELETE tbrecipes
      WHERE  recipe_id = @Recipe_Id
  END

go

CREATE PROC Selection
AS
    SELECT *
    FROM   tbrecipes

go

CREATE PROC Selectline @Recipe_Id INT
AS
    SELECT *
    FROM   tbrecipes
    WHERE  recipe_id = @Recipe_Id

go

--לצורך בדיקות
EXEC Selection

EXEC Selectline
  2 