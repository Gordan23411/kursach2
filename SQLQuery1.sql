CREATE TABLE Agent
(
    Id_agent int IDENTITY NOT NULL 
            PRIMARY KEY,
    FName NVARCHAR(50),
	LName NVARCHAR(50),
	PassportData NVARCHAR(50),
	Phone NVARCHAR(50),
	Email NVARCHAR(50)
)

CREATE TABLE Country
(
    ID_country int IDENTITY NOT NULL 
            PRIMARY KEY,
    Name NVARCHAR(50),
)

CREATE TABLE Hotel
(
    ID_hotel int IDENTITY NOT NULL 
            PRIMARY KEY,
    HotelName NVARCHAR(50),
	Country_ID int NOT NULL						                        
    	FOREIGN KEY REFERENCES Country(ID_country), -- ����� ���� �� ������.
	City NVARCHAR(50),
	Rating INT,
	Information NVARCHAR(50)
)

CREATE TABLE Service
(
    ID_Service int IDENTITY NOT NULL 
            PRIMARY KEY,
    Title NVARCHAR(50),
)

CREATE TABLE HotelService
(
    ID_HotelService int IDENTITY NOT NULL 
            PRIMARY KEY,
    Hotel_id int NOT NULL						                        
    	FOREIGN KEY REFERENCES Hotel(ID_hotel), -- ����� ���� �� ������.
	Service_id int NOT NULL						                        
    	FOREIGN KEY REFERENCES Service(ID_Service), -- ����� ���� �� ������.
)

CREATE TABLE Tour
(
    ID_Tour int IDENTITY NOT NULL 
            PRIMARY KEY,
    TourName NVARCHAR(50),
	Country_ID  int NOT NULL						                        
    	FOREIGN KEY REFERENCES Country(ID_country), -- ����� ���� �� ������.
	Information NVARCHAR(50),
	Hotel_id int NOT NULL						                        
    	FOREIGN KEY REFERENCES Hotel(ID_hotel), -- ����� ���� �� ������.
	DateBegin DateTime,
	DateEnd DateTime,
	Price Money,
	Seats int
)

CREATE TABLE Tourist
(
    ID_tourist int IDENTITY NOT NULL 
            PRIMARY KEY,
    FName NVARCHAR(50),
	LName NVARCHAR(50),
	PassportData NVARCHAR(50),
	Phone NVARCHAR(50),
	Email NVARCHAR(50)
)


CREATE TABLE Travel
(
    ID_Travel int IDENTITY NOT NULL 
            PRIMARY KEY,
    Tour_ID int NOT NULL						                        
    	FOREIGN KEY REFERENCES Tour(ID_Tour), -- ����� ���� �� ������.
	Fare Money,
	CostTour Money,
	DiscountedPrice Money,
	DateOfIssue DateTime,
	Agent_id  int NOT NULL						                        
    	FOREIGN KEY REFERENCES Agent(Id_agent), -- ����� ���� �� ������.
	Tourist_id  int NOT NULL						                        
    	FOREIGN KEY REFERENCES Tourist(ID_tourist), -- ����� ���� �� ������.
)