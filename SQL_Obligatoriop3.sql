
--Drop Table NombreVulgar
Use Obligatoriop3EF
Go

--Tipo de Plantas

Insert into TipoDePlantas values ('Arbol','Estas plantas tienen un tallo leñoso con una altura superior a los 6 metros')
Insert into TipoDePlantas values ('Arbusto','Miden entre uno y seis metros de altura, sus ramas son cortas y comienzan a nivel de la tierra.')
Insert into TipoDePlantas values ('Hierbas','Estas plantas tienen tallos que no han desarrollado estructuras leñosas o endurecidas.')
Insert into TipoDePlantas values ('Gimnospermas','Aunque tienen flores, la función reproductora es llevada a cabo por sus hojas en forma de escamas')
Insert into TipoDePlantas values ('Angiospermas','Tienen flores y son las encargadas de la reproducción a través de los frutos y semillas.')
Insert into TipoDePlantas values ('Anuales','Son aquellas que suelen crecer rápidamente, pero tienen un tiempo de vida muy corto.')
Insert into TipoDePlantas values ('Bienales','Son aquellas plantas que necesitan dos estaciones desde que se siembran hasta que florecen.')
Insert into TipoDePlantas values ('Perennes','Estas suelen vivir más de dos años, puesto que tienen tallos herbáceos')
Insert into TipoDePlantas values ('Trepadoras','Son plantas con tallos no erectos y estructuras con forma de ganchos.')
Insert into TipoDePlantas values ('Ornamentales','Este tipo de plantas son usadas con fines decorativos o de coleccionismo.')
Insert into TipoDePlantas values ('Suculentas','Logran modificar cualquiera de sus estructuras (hojas, tallos, raíces) para almacenar agua.')
Insert into TipoDePlantas values ('Tuberosas','Se desarrollan a través de un tubérculo')
Insert into TipoDePlantas values ('Acuaticas','Este tipo de especies de plantas viven normalmente sobre el agua o en los estanques')

--Tipo de Iluminacion
Insert into Iluminaciones values('Luz solar directa')
Insert into Iluminaciones values('Luz solar indirecta')
Insert into Iluminaciones values('Sombra')

--Ficha de Cuidado
Insert into FichaDeCuidados values(2,'dias',20,1)
Insert into FichaDeCuidados values(2,'semanas',15,2)
Insert into FichaDeCuidados values(5,'dias',24,3)
Insert into FichaDeCuidados values(2,'semanas',11,1)
Insert into FichaDeCuidados values(1,'dia',25,2)
Insert into FichaDeCuidados values(4,'dias',14,3)
Insert into FichaDeCuidados values(1,'semana',11,3)
Insert into FichaDeCuidados values(4,'semanas',10,2)
Insert into FichaDeCuidados values(2,'dias',17,1)
Insert into FichaDeCuidados values(1,'dia',20,1)
Insert into FichaDeCuidados values(8,'dias',23,3)
Insert into FichaDeCuidados values(15,'dias',19,1)

--Planta
insert into Plantas values(1,'Cedrelatubiflora','Es una especie botanica de arbol de la clase dicots familia de las Meliaceas','Exterior',756,'Cedrela_tubiflora.png',8,1140)
insert into Plantas values(1,'Robinia pseudoacacia','Es de las tres «falsas acacias» plantadas en ciudades del mundo para adornar calles y parques.','Exterior',2500,'Robinia_pseudoacacia.jpg',8,5140)
insert into Plantas values(1,'Cercis siliquastrum','es una especie arbórea de la familia de las leguminosas','Exterior',400,'Cercis_siliquastrum.png',8,640)
insert into Plantas values(1,'Brachychiton acerifolium','Es una especie arbórea nativa de regiones subtropicales de la costa este de Australia','Exterior',900,'Brachychiton_acerifolium.png',8,2540)
insert into Plantas values(1,'Erythrina crista-galli',' Es un árbol de la familia Fabaceae originario de Sudamérica','Exterior',500,'Erythrina_crista-galli.jpg',4,740)
insert into Plantas values(1,'Platanus','Es un árbol monoico, caducifolio de ramas abiertas y amplia copa.','Exterior',4500,'Platanus.png',8,1490)
insert into Plantas values(2,'Salix','La madera de los sauces es dura y flexible. Poseen esbeltas y fibrosas ramas','Exterior',950,'Salix.jpg',8,8456)
insert into Plantas values(1,'Pinus strobus','Este pino gusta del frío, suelos húmedos bien drenados y crecimiento en bosques mixtos','Exterior',4000,'Pinus_strobus.png',8,1420)
insert into Plantas values(1,'Ageratum houstonianum','El Agerato es una planta vivaz y herbácea que presenta hojas opuestas con forma lanceolada','Exterior',40,'Ageratum houstonianum.jpg',11,440)
--interior
insert into Plantas values(3,'Polianthes tuberosa','Son plantas de raíces con tubérculos, rizoma de almacenamiento corto, erecto, cilíndrico','Interior',100,'Polianthes_tuberosa.png',1,240)
insert into Plantas values(12,'Agapanthus','Posee un tallo corto que porta varias hojas alargadas, arciformes','Interior',50,'Agapanthus.jpg',3,330)
insert into Plantas values(10,'Pilea peperomioides','Esta planta se caracteriza por tener hojas redondas, peltadas y de color verde oscuro','Interior',80,'Pilea peperomioides.png',5,465)
insert into Plantas values(11,'Echeveria elegans','Sus hojas ovales, azuladas e hinchadas de agua adquieren todo el protagonismo','Interior',90,'Echeveria_elegans.png',10,150)
insert into Plantas values(10,'Dracena Fragans',' En jardinería se conoce popularmente como Tronco del Brasil, Palo de Brasil o Palo de Agua.','Interior',110,'Dracena_Fragans.png',1,790)

--Nombres Vulgares
Insert into NombreVulgar values('Cedro Misionero',1)				--1		Cedrela tubiflora			1
Insert into NombreVulgar values('Acacia',2)						--2		Robinia pseudoacacia		2	
Insert into NombreVulgar values('Verdadera Acacia',2)				--3		Robinia pseudoacacia		2
Insert into NombreVulgar values('Árbol de Judas',3)				--4		Cercis siliquastrum			3
Insert into NombreVulgar values('Ciclamor',3)						--5		Cercis siliquastrum			3
Insert into NombreVulgar values('Árbol de Judea',3)				--6		Cercis siliquastrum			3
Insert into NombreVulgar values('Árbol de la Llama',4)			--7		Brachychiton acerifolium	4
Insert into NombreVulgar values('Ceibo',5)						--8		Erythrina crista-galli		5
Insert into NombreVulgar values('Plátano',6)						--9		Platanus					6
Insert into NombreVulgar values('Sauce',7)						--10	Salix						7
Insert into NombreVulgar values('Pino Blanco',8)					--11	Pinus strobus				8
Insert into NombreVulgar values('Damasquino',9)					--12	Ageratum houstonianum		9
Insert into NombreVulgar values('El nardo',10)					--13	Polianthes tuberosa			10
Insert into NombreVulgar values('Agapanto',11)					--14	Agapanthus					11
Insert into NombreVulgar values('Planta China del Dinero',12)		--15	Pilea peperomioides			12
Insert into NombreVulgar values('Rosa de Alabastro',13)			--16	Echeveria elegans			13
Insert into NombreVulgar values('Palo de Agua',14)				--17	Drácena Fragans				14

--Tasas
Insert into Tasas values('Iva',22)
Insert into Tasas values('Tasa Arancelaria',10)
Insert into Tasas values('Impuesto Importacion',20)


--select * from TipoDePlantas
--select * from Compras
--select * from Facturacion
--select * from Plantas
--select * from Tasas

