INSERT INTO Roles(RoleName) 
VALUES
('�������������'),
('������������')

INSERT INTO Users(Username, Password, FullName, RoleId, IsRegistered, IsBlocked) 
VALUES
('admin', 'admin', '������� ����� ���������', 1, 1, 0),
('user1', '12345', '���� �� ������', 2, 1, 0),
('user2', '12345', '���� �� ������', 2, 0, 0)