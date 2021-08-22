/****** Script for SelectTopNRows command from SSMS  ******/
insert into CategoriaProducto values 
('Procesador'),  ('Tarjeta madre'), ('Tarjeta gráfica'), ('RAM'), 
('Almacenamiento'), ('Enfriamiento'), ('Fuente de poder'), ('Case')

insert into EstadoTicket values ('Activo'), ('Cerrado')

insert into Permisos values ('Administrador'), ('Cliente')

insert into Producto values 
('AMD Ryzen 7 5800X', 'Consumo 105W, Frecuencia: 3.8 GHz, Socket AM4', 20, 1, 270000, 0, 1),
('GIGABYTE A520M S2H', 'AMD, Socket AM4, Formato Micro-ATX', 20, 1, 56000, 0, 2),
('MSI GEFORCE GTX 1650 D6 Ventus XS OC', 'MSI, NVIDIA, 4 GB GDDR6', 20, 1, 179000, 0, 3),
('HyperX Fury RGB 8 GB DDR4 3600', '8 GB', 20, 1, 36000, 0, 4),
('Adata Swordfish 250 GB', '1800 MB/s de Lectura, 1200 MB/s de Escritura', 20, 1, 27000, 0, 5),
('Azza Blizzard ARGB 240mm', 'Radiador 240mm, Sockets AMD (AM4, AM3)', 20, 1, 45000, 0, 6),
('SEASONIC CORE GC-550 - 80 PLUS GOLD', '550 W, No modular', 20, 1, 42000, 0, 7),
('AZZA CELESTA 340F - ARGB', 'Mid Tower, Vidrio temperado', 20, 1, 32000, 0, 8)

insert into Usuarios values
('Andres', 'Navarro', 'Blanco', 1, 1, '123', 'test@test'),
('Alejandro', 'Hernandez', 'Lara', 2, 1, '123', 'a@a')

insert into Ticket values
(1, 2, 2, '2020-10-10', 800000, 'Necesito una pc con procesador Ryzen y tarjeta de video GTX 1650')

insert into ProductoTicket values 
(1, 1, 1), (2, 1, 1), (3, 1, 1), (4, 1, 2), (5, 1, 1), (6, 1, 1), (7, 1, 1), (8, 1, 1)

insert into Facturas values (2, 1, '2020-10-10')