CREATE TABLE [dbo].[Rooms] (
    [ID]    INT IDENTITY (1, 1) NOT NULL,
    [Place] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[Bookings] (
    [ID]         INT      IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    [RoomID]     INT      NOT NULL,
    [StartDate]  DATETIME NOT NULL,
    [EndDate]    DATETIME NOT NULL,
    [UsedPlaces] INT      NOT NULL,
    [Gender]     SMALLINT NOT NULL
);

INSERT INTO [dbo].[Rooms] ([Place]) VALUES (2)
INSERT INTO [dbo].[Rooms] ([Place]) VALUES (2)
INSERT INTO [dbo].[Rooms] ([Place]) VALUES (2)
INSERT INTO [dbo].[Rooms] ([Place]) VALUES (2)
INSERT INTO [dbo].[Rooms] ([Place]) VALUES (2)
INSERT INTO [dbo].[Rooms] ([Place]) VALUES (2)
INSERT INTO [dbo].[Rooms] ([Place]) VALUES (1)
INSERT INTO [dbo].[Rooms] ([Place]) VALUES (1)
INSERT INTO [dbo].[Rooms] ([Place]) VALUES (1)
INSERT INTO [dbo].[Rooms] ([Place]) VALUES (3)
INSERT INTO [dbo].[Rooms] ([Place]) VALUES (3)
INSERT INTO [dbo].[Rooms] ([Place]) VALUES (3)
INSERT INTO [dbo].[Rooms] ([Place]) VALUES (3)

INSERT INTO [dbo].[Bookings] ([RoomID], [StartDate], [EndDate], [UsedPlaces], [Gender]) VALUES (1, N'2019-02-11', N'2019-03-10', 1, 1)
INSERT INTO [dbo].[Bookings] ([RoomID], [StartDate], [EndDate], [UsedPlaces], [Gender]) VALUES (1, N'2019-04-20', N'2019-04-21', 1, 2)
INSERT INTO [dbo].[Bookings] ([RoomID], [StartDate], [EndDate], [UsedPlaces], [Gender]) VALUES (1, N'2019-04-04', N'2019-04-21', 1, 1)

INSERT INTO [dbo].[Bookings] ([RoomID], [StartDate], [EndDate], [UsedPlaces], [Gender]) VALUES (2, N'2019-02-11', N'2019-03-10', 1, 1)
INSERT INTO [dbo].[Bookings] ([RoomID], [StartDate], [EndDate], [UsedPlaces], [Gender]) VALUES (2, N'2019-04-10', N'2019-04-21', 1, 2)
INSERT INTO [dbo].[Bookings] ([RoomID], [StartDate], [EndDate], [UsedPlaces], [Gender]) VALUES (2, N'2019-03-04', N'2019-04-23', 1, 1)

INSERT INTO [dbo].[Bookings] ([RoomID], [StartDate], [EndDate], [UsedPlaces], [Gender]) VALUES (3, N'2019-02-11', N'2019-03-10', 1, 1)
INSERT INTO [dbo].[Bookings] ([RoomID], [StartDate], [EndDate], [UsedPlaces], [Gender]) VALUES (4, N'2019-04-10', N'2019-04-21', 1, 2)
INSERT INTO [dbo].[Bookings] ([RoomID], [StartDate], [EndDate], [UsedPlaces], [Gender]) VALUES (5, N'2019-03-04', N'2019-04-23', 1, 1)

