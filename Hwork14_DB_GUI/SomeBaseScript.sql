USE master;									-- Переключаемся на базу данных master
GO

-- Пример закрытия всех подключений к базе данных --------------------------------------------------------------------------------------

DECLARE @kill varchar(max) = '';
SELECT @kill = @kill + 'kill '+CONVERT(varchar(5), session_id) + ';'
FROM master.sys.dm_exec_sessions
WHERE database_id = db_id('InternetShopDB')
EXEC(@kill);
GO
----------------------------------------------------------------------------------------------------------------------------------------



-- Пример удаления базы данных и таблиц-------------------------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM master.sys.databases WHERE name = 'InternetShopDB')	
	DROP DATABASE InternetShopDB;			-- Удаляем базу данных InternetShopDB, если она существует
GO

CREATE DATABASE InternetShopDB;				-- Создаем базу данных InternetShopDB
GO

USE InternetShopDB;							-- Переключаемся на базу данных InternetShopDB
GO

IF OBJECT_ID('Clients', 'U') IS NOT NULL
	DROP TABLE Clients;						-- Удаляем таблицу Clients, если существует
GO

IF OBJECT_ID('ClientsAdditional', 'U') IS NOT NULL
	DROP TABLE ClientsAdditional;			-- Удаляем таблицу ClientsAdditional, если существует
GO

IF OBJECT_ID('Products', 'U') IS NOT NULL
	DROP TABLE Products;					-- Удаляем таблицу Products, если существует
GO

IF OBJECT_ID('Orders', 'U') IS NOT NULL
	DROP TABLE Orders;						-- Удаляем таблицу Orders, если существует
GO
----------------------------------------------------------------------------------------------------------------------------------------



-- Пример создания таблиц, используя ограничения, разные виды связей между таблицами и соблюдая требования нормальной формы ------------

CREATE TABLE Clients						-- Создаем таблицу Clients. Связь один к одному с таблицей ClientDetails. Связь один ко многим с таблицей Orders.		
(
	-- 1-ый параметр - имя столбца; 2-ой - тип данных;
	-- IDENTITY					задает начальное значение и устанавливает авто инкремент; IDENTITY(1, 2) - начальное значение 1, шаг - 2 (по-умолчанию 1, 1);
	-- PRIMARY KEY				указывает, что на столбце задается первичный ключ; 
	--							Для таблицы может существовать только один первичный ключ (простой или составной);	
	--							Не может хранить значение NULL;
	-- UNIQUE					альтернативный ключ; Указывает, что все значения для данного столбца должны быть уникальны;	
	--							Может хранить значение NULL;				
	-- NULL/NOT NULL			указывает, что может ли данное поле быть пустым;
	-- DEFAULT					присваивает значение по умолчанию;
	-- []						используются, если в качетсве имени столбца выступает ключевое слово или же есть пробелы;
	-- CHECK					позволяет задать логическое условие, которое должно быть истинным при вставке или обновлении данных в таблице;

	IdClient int IDENTITY(1,2) NOT NULL PRIMARY KEY,	-- Простой первичный ключ на столбце IdClient	
	[Phone Number] char(12) UNIQUE,	
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,	
	City nvarchar(20) DEFAULT 'Kiev',	

	CHECK ([Phone Number] LIKE '([0-9][0-9][0-9])[0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)  
GO

CREATE TABLE ClientDetails				-- Создаем таблицу ClientDetails. Связь один к одному с таблицей Clients.
(
	--FOREIGN KEY REFERENCES	связывает таблицу с родительской таблицей по указаному первичному (PRIMARY KEY) или альтернативному (UNIQUE) ключу;

	IdClient int PRIMARY KEY 
	FOREIGN KEY REFERENCES Clients(IdClient)	-- Родительская таблица Clients и ее первичный ключ IdClient	
	-- При DELETE/UPDATE в таблице Clients ключевого значения выполняются следующие действия:
	-- NO ACTION    - в дочерней таблице в связанных строках не произойдет никаких изменений; NO ACTION - значение по умолчанию;
	-- CASCADE		- в дочерней таблице при UPDATE в связанных строках обновятся значения, при DELETE связанные строки удаляться;
	-- SET DEFAULT	- в дочерней таблице в связанных строках указанное поле примет значение по умолчанию;
	-- SET NULL 	- в дочерней таблице в связанных строках указанное поле примет значение NULL;	
	ON DELETE CASCADE									
	ON UPDATE CASCADE,	
	BrthDay date NOT NULL,					
	Photo varbinary(max),		
	Email nvarchar(50) UNIQUE,

	CHECK (Email LIKE '%@%.%')
)  
GO

CREATE TABLE Orders							-- Создаем таблицу Orders. Связь один ко многим с таблицей Products.
(	
	IdOrder int IDENTITY PRIMARY KEY,	
	IdClient int NOT NULL
	FOREIGN KEY REFERENCES Clients(IdClient)			
	ON DELETE CASCADE									
	ON UPDATE CASCADE,

	[Date] date NOT NULL,
	[Description] nvarchar(50) NOT NULL	
)   
GO

CREATE TABLE Products						-- Создаем таблицу Products. Связь один ко многим с таблицей Orders.		
(
	IdProduct int IDENTITY NOT NULL PRIMARY KEY,
	Name nvarchar(50) NOT NULL,
	Price money NOT NULL
) 
GO


CREATE TABLE OrdersProducts					-- Создаем таблицу OrdersProducts. Является промежуточной таблицей между таблицами Orders и Products.		
(
	IdOrder int NOT NULL
	FOREIGN KEY REFERENCES Orders(IdOrder)			
	ON DELETE CASCADE									
	ON UPDATE CASCADE,
	 
	IdProduct int NOT NULL
	FOREIGN KEY REFERENCES Products(IdProduct) 	
	ON DELETE CASCADE									
	ON UPDATE CASCADE,

	[Count] int NOT NULL,
	TotalPrice money NOT NULL 

	PRIMARY KEY (IdOrder, IdProduct) -- Составной первичный ключ на столбцах IdOrder, IdProduct;	
)

----------------------------------------------------------------------------------------------------------------------------------------

-- Пример заполнения данными таблиц базы данных ----------------------------------------------------------------------------------------

INSERT INTO Clients VALUES 
('(099)1234567','Oleg','Olegov','Odessa'),		-- IdClient = 1
('(093)1234567','Ivan','Ivanov','Kharkov'),		-- IdClient = 3
('(063)1234567','Nikolay','Nikolaev','Minsk'),	-- IdClient = 5
('(050)1234567','Oleg','Nikolaev','Rovno'),		-- IdClient = 7
('(065)1234567','Ivan','Nikolaev','Dnepr'),		-- IdClient = 9
('(073)1234567','Nikolay','Olegov','Donetsk'),	-- IdClient = 11
('(088)1234567','Nikolay','Ivanov','Poltava')	-- IdClient = 13
GO

INSERT INTO ClientDetails  VALUES 
(1, '1980-6-17', NULL, 'oleg@gmail.com'),
(3, '1985-1-23', NULL, 'ivan@gmail.com'),
(5, '1995-4-11', NULL, 'nik@gmail.com');
GO

INSERT INTO Orders  
VALUES 
(1, '2015-2-13', 'Some order of client 1'),		-- IdOrder = 1
(1, '2015-1-2',  'Other order of client 1'),	-- IdOrder = 2
(3, '2015-7-1',  'Some order of client 3'),		-- IdOrder = 3
(3, '2015-9-21',  'Other order of client 3'),	-- IdOrder = 4
(5, '2015-10-19',  'Some order of client 5'),	-- IdOrder = 5
(5, '2015-11-22',  'Other order of client 5'),	-- IdOrder = 6
(7, '2015-12-25',  'Some order of client 7'),	-- IdOrder = 7
(7, '2016-1-1',  'Other order of client 7');	-- IdOrder = 8
GO

INSERT INTO Products VALUES 
('Computer', 3500),		-- IdProduct = 1
('Mouse', 100),			-- IdProduct = 2
('Keyboard', 150),		-- IdProduct = 3
('Smartphone', 2000),	-- IdProduct = 4
('Headphones', 700),	-- IdProduct = 5
('Video display', 1500),-- IdProduct = 6
('WiFi router', 300);	-- IdProduct = 7
GO


INSERT INTO OrdersProducts  VALUES 
(1, 1, 2,  (SELECT price FROM Products WHERE IdProduct = 1 ) * 2),
(1, 2, 3,  (SELECT price FROM Products WHERE IdProduct = 2 ) * 3),
(2, 5, 1,  (SELECT price FROM Products WHERE IdProduct = 5 ) * 1),
(2, 7, 2,  (SELECT price FROM Products WHERE IdProduct = 7 ) * 2),
(3, 5, 4,  (SELECT price FROM Products WHERE IdProduct = 5 ) * 4),
(3, 6, 7,  (SELECT price FROM Products WHERE IdProduct = 6 ) * 7),
(4, 2, 4,  (SELECT price FROM Products WHERE IdProduct = 2 ) * 4),
(4, 4, 2,  (SELECT price FROM Products WHERE IdProduct = 4 ) * 2),
(5, 5, 1,  (SELECT price FROM Products WHERE IdProduct = 5 ) * 1),
(5, 7, 6,  (SELECT price FROM Products WHERE IdProduct = 7 ) * 6),
(6, 3, 3,  (SELECT price FROM Products WHERE IdProduct = 3 ) * 3),
(6, 1, 4,  (SELECT price FROM Products WHERE IdProduct = 1 ) * 4),
(7, 4, 1,  (SELECT price FROM Products WHERE IdProduct = 4 ) * 1),
(7, 5, 2,  (SELECT price FROM Products WHERE IdProduct = 5 ) * 2),
(8, 6, 5,  (SELECT price FROM Products WHERE IdProduct = 6 ) * 5),
(8, 1, 3,  (SELECT price FROM Products WHERE IdProduct = 1 ) * 3);
GO


SELECT * FROM Clients;
SELECT * FROM ClientDetails;
SELECT * FROM Orders;
SELECT * FROM Products;
SELECT * FROM OrdersProducts;
GO
---------------------------------------------------------------------------------------------------