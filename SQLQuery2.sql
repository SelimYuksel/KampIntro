--Select
--ANSII
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'London'

--Case insensitive
select * from Products where CategoryID=1 or CategoryID=3

select * from Products where categoryID=1 and UnitPrice>=10

select * from Products where CategoryID=1 order by UnitPrice desc   --ascending artan demek  --descending azalan demek

select count(*) Adet from Products where CategoryID=2

select categoryID, count(*) from Products where Unitprice>20 group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories        --inner join iki tabloda da varsa eşleştirir
on products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object

select * from Products p inner join [Order Details] od  --left join solda olup sağda olmayanları da getir
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderID=od.OrderID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null