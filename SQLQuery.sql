select p.ProductName, sum(od.UnitPrice*od.Quantity) as total from products p
inner join [Order Details] od on p.ProductID=od.ProductID
group by p.ProductName

select * from Orders
select * from Products
select * from [Order Details]