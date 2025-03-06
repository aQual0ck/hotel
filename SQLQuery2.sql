WITH SoldNights AS (
    SELECT 
        SUM(DATEDIFF(day, MoveInDate, MoveOutDate)) AS total_sold_nights
    FROM RoomsClients
),
TotalRooms AS (
    SELECT COUNT(*) AS total_rooms FROM Rooms
),
Period AS (
    SELECT DATEDIFF(day, '2025-02-01', '2025-03-31') + 1 AS total_days
)
SELECT 
    (s.total_sold_nights * 100.0) / (r.total_rooms * p.total_days) AS occupancy_percentage
FROM SoldNights s, TotalRooms r, Period p;