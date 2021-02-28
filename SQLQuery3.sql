select ProductName UrunAdi, sum(od.UnitPrice * od.Quantity) KazanilanToplamMiktar 
from [Order Details] od inner join orders o on od.OrderID=o.OrderID inner join Products p on od.ProductID=p.ProductID
group by ProductName