CREATE TABLE [dbo].[HotelInformation] (
    [HotelID]      INT            IDENTITY (1, 1) NOT NULL,
    [HotelName]    NVARCHAR (50)  NULL,
    [City]         NVARCHAR (50)  NULL,
    [Street]       NVARCHAR (50)  NULL,
    [Feedback]     FLOAT (53)     NULL,
    [Price]        FLOAT (53)     NULL,
    [HotelImage]   IMAGE          NULL,
    [email]        NVARCHAR (50)  NULL,
    [zipcode]      NVARCHAR (50)  NULL,
    [FloorsNumber] INT            NULL,
    [Capacity]     INT            NULL,
    [PhoneNumber]  NVARCHAR (20)  NULL,
    [Country]      NVARCHAR (20)  NULL,
    [AdminID]      INT            NULL,
    [Descriptions] NVARCHAR (500) NULL,
    [LatPoint]     FLOAT (53)     DEFAULT ((0)) NULL,
    [LngPoint]     FLOAT (53)     DEFAULT ((0)) NULL
);


CREATE TABLE [dbo].[RoomInformation] (
    [RoomID]    INT           IDENTITY (1, 1) NOT NULL,
    [RoomType]  NVARCHAR (50) NULL,
    [RoomBed]   NVARCHAR (50) NULL,
    [RoomPrice] FLOAT (53)    NULL,
    [Status]    NVARCHAR (50) NULL,
    [RoomName]  NVARCHAR (50) NULL,
    [CheckIn]   DATETIME      NULL,
    [Checkout]  DATETIME      NULL,
    [RoomImage] IMAGE         NULL,
    [Clients]   INT           NULL,
    [size]      FLOAT (53)    NULL,
    [HotelID]   INT           NULL
);

CREATE TABLE [dbo].[UserRegister] (
    [ID]           INT           IDENTITY (1, 1) NOT NULL,
    [Useremail]    NVARCHAR (50) NULL,
    [Password]     NVARCHAR (50) NULL,
    [National]     NVARCHAR (50) NULL,
    [Genders]      NVARCHAR (50) NULL,
    [Idcardnumber] NVARCHAR (50) NULL,
    [Address]      NVARCHAR (50) NULL,
    [Phonenumber]  NVARCHAR (50) NULL,
    [BirthDay]     DATETIME      NULL,
    [role]         NVARCHAR (50) NULL
);

CREATE TABLE [dbo].[Booking] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [CustomerName]  NVARCHAR (50) NULL,
    [CheckIn]       DATETIME      NULL,
    [CheckOut]      DATETIME      NULL,
    [BookingDate]   DATETIME      NULL,
    [PaymentStatus] NVARCHAR (50) NULL,
    [BookingStatus] NVARCHAR (50) NULL,
    [UserID]        INT           NULL,
    [RoomID]        INT           NULL,
    [HotelID]       INT           NULL,
    [Price]         FLOAT (53)    NULL,
    [isCheckOut]    BIT           DEFAULT ((0)) NULL
);



CREATE TABLE [dbo].[Hotel_conveniences] (
    [HotelID]               INT NULL,
    [Breakfast]             BIT DEFAULT ((0)) NULL,
    [Free_WiFi]             BIT DEFAULT ((0)) NULL,
    [247_Room_Service]      BIT DEFAULT ((0)) NULL,
    [Daily_Housekeeping]    BIT DEFAULT ((0)) NULL,
    [Restaurant_and_Bar]    BIT DEFAULT ((0)) NULL,
    [Swimming_Pool_and_Spa] BIT DEFAULT ((0)) NULL,
    [Laundry_Service]       BIT DEFAULT ((0)) NULL,
    [Parking_area]          BIT DEFAULT ((0)) NULL,
    [Gym]                   BIT DEFAULT ((0)) NULL
);

CREATE TABLE [dbo].[Bathroomconveniences] (
    [RoomID]               INT NULL,
    [Private_bathroom]     BIT DEFAULT ((0)) NULL,
    [Personal_hygiene_kit] BIT DEFAULT ((0)) NULL,
    [Hair_dryer]           BIT DEFAULT ((0)) NULL,
    [Standing_shower]      BIT DEFAULT ((0)) NULL,
    [Large_mirror]         BIT DEFAULT ((0)) NULL,
    [Bluetooth_speaker]    BIT DEFAULT ((0)) NULL,
    [Ventilation_system]   BIT DEFAULT ((0)) NULL
);



CREATE TABLE [dbo].[RoomConveniences] (
    [RoomID]             INT NULL,
    [Air_conditioner]    BIT DEFAULT ((0)) NULL,
    [TV]                 BIT DEFAULT ((0)) NULL,
    [Curtains]           BIT DEFAULT ((0)) NULL,
    [Desk_workspace]     BIT DEFAULT ((0)) NULL,
    [Small_kitchen]      BIT DEFAULT ((0)) NULL,
    [Refrigerator]       BIT DEFAULT ((0)) NULL,
    [Coffee_maker]       BIT DEFAULT ((0)) NULL,
    [Free_bottled_water] BIT DEFAULT ((0)) NULL,
    [Safe_box]           BIT DEFAULT ((0)) NULL
);

CREATE TABLE [dbo].[Payment] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [AddDate]       DATETIME      NULL,
    [PaymentMethod] NVARCHAR (50) NULL,
    [Amount]        FLOAT (53)    NULL,
    [BookingID]     INT           NULL,
    [HotelID]       INT           NULL
);

CREATE TABLE [dbo].[UserFullName] (
    [ID]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (32) NULL,
    [UID]  INT           NULL
);




CREATE TABLE [dbo].[Evaluate] (
    [ID]      INT            IDENTITY (1, 1) NOT NULL,
    [Rate]    FLOAT (53)     NULL,
    [Comment] NVARCHAR (500) NULL,
    [HotelID] INT            NULL,
    [UserID]  INT            NULL,
    [DateT]   DATETIME       NULL
);

