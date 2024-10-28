Use TestSQL

Create Table Category
(CategoryId int Identity Constraint PK_Customer_CategoryId Primary Key,
 CategoryName nvarchar(50) Null)

 Create Table Products
 (ProductId int Identity Constraint PK_Customer_ProductId Primary Key,
  ProductName nvarchar(50) Null)

 Create Table Basket
 (
	ProductId int Constraint FK_Customer_ProductId Foreign Key References Products (ProductId),
	CategoryId int Constraint FK_Customer_CategoryId Foreign Key References Category (CategoryId)
 )

 Insert Category
 Values ('Мясо'), ('Рыба'), ('Морепродукты'), ('Молочные продукты'), ('Фрукты'), ('Ягоды')

 Insert Products 
 Values ('Дичь'), ('Форель'), ('Окунь'), ('Рак'), ('Сыр'), ('Творог'), ('Арбуз'), ('Смородина'), ('Ананас')

 Insert Basket Values  (1,1), (2,2), (3,2), (4,3), (5,4), (6,4), (9,5), (8,6), (4,1), (7,null)

 Select P.ProductName, C.CategoryName from Basket as B
 Left Join Products as P on B.ProductId = P.ProductId
 Left Join Category as C on B.CategoryId = C.CategoryId
 