INSERT INTO Roles(RoleName) 
VALUES
('Администратор'),
('Пользователь')

INSERT INTO Users(Username, Password, FullName, RoleId, IsRegistered, IsBlocked) 
VALUES
('admin', 'admin', 'Админов Админ Админович', 1, 1, 0),
('user1', '12345', 'Поль Зо Ватель', 2, 1, 0),
('user2', '12345', 'Поль За Ватель', 2, 0, 0)