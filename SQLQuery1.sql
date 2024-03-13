select * from RoomInformation
update RoomInformation set  Status = 'Occupied' where RoomID = 2

create table HotelInformation
(
	HotelID int identity,
	HotelName nvarchar(50),
	City nvarchar(50),
	Street nvarchar(50),
	Feedback Float,
	Price Float,
	HotelImage Image
)

select * from HotelInformation
INSERT INTO HotelInformation (HotelName, City, Street, Feedback, Price, HotelImage)
SELECT 'Terracotta Hotel & Resort Đà Lạt', 'Da lat', 'Lavender', 8.6, 800, RoomImage
FROM RoomInformation
WHERE RoomID = 3;
