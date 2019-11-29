Create Database MyStoreApps
GO
Use MyStoreApps
GO
Create Table tblTourist
(
	id Int Primary Key,
	title Nvarchar(10) Not Null,
	firstName Nvarchar(20) Not Null,
	lastName Nvarchar(20)Not Null,
	country Nvarchar(20)Not Null,
	passportNo Nvarchar(20) Not Null,
	email Nvarchar(20) Not Null,
	phoneNo Nvarchar(20) Not Null
)
GO
Insert Into tblTourist Values(001,'Mr','Emdadul','Haque','Bangladesh','bd1047647R51','emdadulhaque585@gmail.com','01721760389')
Update tblTourist Set title='',firstName='',lastName='',country='',passportNo='',email='',phoneNo='' where id=001;
Delete from tblTourist Where id=001