use SERVIEXPRESS
go

create sequence secuencia_almacen
start with 1
increment by 1
go	

create sequence secuencia_horario
start with 1
increment by 1
go

create sequence secuencia_dia
start with 1
increment by 1
go

create sequence secuencia_usuario_emp
start with 1
increment by 1
go

create sequence secuencia_pedido
start with 1
increment by 1
go

create sequence secuencia_detalle_pe
start with 1
increment by 1
go

create sequence secuencia_familia
start with 1
increment by 1
go

create sequence secuencia_marca
start with 1
increment by 1
go
create sequence secuencia_categoria
start with 1
increment by 1
go

create sequence secuencia_servicios
start with 1
increment by 1
go

create sequence secuencia_proveedor
start with 1
increment by 1
go

create sequence secuencia_producto
start with 1
increment by 1
go

create sequence secuencia_pro_al
start with 1
increment by 1
go

insert into rol
values
(1,'empleado'),
(2,'administrador')
go

insert into usuario_empresa
values
(next value for secuencia_usuario_emp,'juan@gmail.com','duocduoc',convert(date,sysdatetime()),1,1),
(next value for secuencia_usuario_emp,'carmen@gmail.com','sys2020',convert(date,sysdatetime()),1,1)
go

insert into ficha_empleado
values
(96715552,'juan pedro','armijo castillo','san antonio 2525',974576122,null,'1995-06-03',1),
(98054979,'carmen nadia','fernadez rios','bulnes 174',974576122,null,'1989-11-21',2)

insert into almacen
values
(next value for secuencia_almacen, 'los coquimbos 12', 'taller princial',1),
(next value for secuencia_almacen,'paseo ahumada 80','almacen reserva',1)
go

insert into dia_habil
values 
(next value for secuencia_dia,'lunes','2020-06-22',1),
(next value for secuencia_dia,'martes','2020-06-23',1),
(next value for secuencia_dia,'miercoles','2020-06-24',1),
(next value for secuencia_dia,'jueves','2020-06-25',1),
(next value for secuencia_dia,'viernes','2020-06-26',1),

(next value for secuencia_dia,'lunes','2020-06-29',1),
(next value for secuencia_dia,'martes','2020-06-30',1),
(next value for secuencia_dia,'miercoles','2020-06-01',1),
(next value for secuencia_dia,'jueves','2020-06-02',1),
(next value for secuencia_dia,'viernes','2020-06-03',1)



insert into bloque_hora
values
(next value for secuencia_horario,96715552,1,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,96715552,1,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,96715552,1,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,96715552,1,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,96715552,1,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,96715552,1,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,96715552,1,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,96715552,1,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,98054979,1,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,98054979,1,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,98054979,1,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,98054979,1,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,98054979,1,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,98054979,1,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,98054979,1,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,98054979,1,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,96715552,2,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,96715552,2,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,96715552,2,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,96715552,2,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,96715552,2,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,96715552,2,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,96715552,2,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,96715552,2,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,98054979,2,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,98054979,2,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,98054979,2,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,98054979,2,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,98054979,2,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,98054979,2,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,98054979,2,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,98054979,2,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,96715552,3,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,96715552,3,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,96715552,3,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,96715552,3,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,96715552,3,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,96715552,3,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,96715552,3,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,96715552,3,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,98054979,3,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,98054979,3,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,98054979,3,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,98054979,3,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,98054979,3,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,98054979,3,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,98054979,3,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,98054979,3,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,96715552,4,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,96715552,4,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,96715552,4,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,96715552,4,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,96715552,4,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,96715552,4,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,96715552,4,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,96715552,4,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,98054979,4,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,98054979,4,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,98054979,4,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,98054979,4,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,98054979,4,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,98054979,4,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,98054979,4,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,98054979,4,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,96715552,5,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,96715552,5,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,96715552,5,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,96715552,5,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,96715552,5,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,96715552,5,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,96715552,5,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,96715552,5,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,98054979,5,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,98054979,5,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,98054979,5,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,98054979,5,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,98054979,5,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,98054979,5,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,98054979,5,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,98054979,5,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,96715552,6,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,96715552,6,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,96715552,6,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,96715552,6,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,96715552,6,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,96715552,6,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,96715552,6,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,96715552,6,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,98054979,6,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,98054979,6,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,98054979,6,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,98054979,6,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,98054979,6,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,98054979,6,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,98054979,6,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,98054979,6,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,96715552,7,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,96715552,7,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,96715552,7,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,96715552,7,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,96715552,7,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,96715552,7,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,96715552,7,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,96715552,7,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,98054979,7,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,98054979,7,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,98054979,7,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,98054979,7,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,98054979,7,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,98054979,7,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,98054979,7,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,98054979,7,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,96715552,8,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,96715552,8,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,96715552,8,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,96715552,8,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,96715552,8,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,96715552,8,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,96715552,8,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,96715552,8,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,98054979,8,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,98054979,8,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,98054979,8,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,98054979,8,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,98054979,8,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,98054979,8,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,98054979,8,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,98054979,8,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,96715552,9,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,96715552,9,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,96715552,9,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,96715552,9,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,96715552,9,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,96715552,9,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,96715552,9,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,96715552,9,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,98054979,9,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,98054979,9,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,98054979,9,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,98054979,9,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,98054979,9,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,98054979,9,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,98054979,9,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,98054979,9,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,96715552,10,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,96715552,10,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,96715552,10,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,96715552,10,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,96715552,10,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,96715552,10,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,96715552,10,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,96715552,10,'17:01:00','18:00:00',1,08),
(next value for secuencia_horario,98054979,10,'08:01:00','09:00:00',1,01),
(next value for secuencia_horario,98054979,10,'09:01:00','10:00:00',1,02),
(next value for secuencia_horario,98054979,10,'10:01:00','11:00:00',1,03),
(next value for secuencia_horario,98054979,10,'11:01:00','12:00:00',1,04),
(next value for secuencia_horario,98054979,10,'13:01:00','14:00:00',1,05),
(next value for secuencia_horario,98054979,10,'15:01:00','16:00:00',1,06),
(next value for secuencia_horario,98054979,10,'16:01:00','17:00:00',1,07),
(next value for secuencia_horario,98054979,10,'17:01:00','18:00:00',1,08)

go

insert into tipo_boleta
values 
(1,'boleta de producto'),
(2,'boletas de servicio')
go

insert into categoria_servicio
values 
(next value for secuencia_categoria,'mantencion'),
(next value for secuencia_categoria,'cambio de piezas'),
(next value for secuencia_categoria,'diagnostico')
go

insert into servicios
values 
(next value for secuencia_servicios,'cambio de lubricante del motor','$5000',1,'cambio de aceite',1),
(next value for secuencia_servicios,'mantencion del kilometraje al auto','$3000',1,'mantencion del kilometraje',1),
(next value for secuencia_servicios,'mantencion y o cambio de frenos','$5000',1,'frenos',1),
(next value for secuencia_servicios,'cambio de baterias del auto','$6000',1,'baterias',2),
(next value for secuencia_servicios,'diagnostico general del auto','$10000',1,'diagnostico general',3),
(next value for secuencia_servicios,'diagnostico electrico del auto','$8000',1,'diagnostico electrico',3),
(next value for secuencia_servicios,'instalacion de piezas del auto','$7000',1,'instalacion de piezas',2)

insert into familia_producto 
values
(next value for secuencia_familia,'neumaticos',1),
(next value for secuencia_familia, 'llantass',1),
(next value for secuencia_familia,'baterías',1),
(next value for secuencia_familia,'lubricantes',1),
(next value for secuencia_familia,'aditivos',1),
(next value for secuencia_familia,'anticongelantes',1),
(next value for secuencia_familia,'anticorrosivos',1),
(next value for secuencia_familia,'liquido de frenos',1)
go

insert into marca_producto
values
(next value for secuencia_marca,'BKT',1),
(next value for secuencia_marca,'Zeta',1),
(next value for secuencia_marca,'Hankook',1),
(next value for secuencia_marca,'Austone',1),
(next value for secuencia_marca,'SLK',1),
(next value for secuencia_marca,'Full neumaticos',1),
(next value for secuencia_marca,'Bosch',1),
(next value for secuencia_marca,'karson',1),
(next value for secuencia_marca,'Autostyle',1),
(next value for secuencia_marca,'Movil',1),
(next value for secuencia_marca,'Liquimoly',1),
(next value for secuencia_marca,'Gumout',1),
(next value for secuencia_marca,'WD-40',1)
go

insert into proveedor
values
(next value for secuencia_proveedor,'proveemax',948771669,'proveedor con establecimiento en el centro de santiago','proveemax@empresa.cl',1,180174984-2,'estado 542 santiago centro'),
(next value for secuencia_proveedor,'providen',179965149,'proveedor con establecimiento en providencia','providen@provisiones.cl',1,206489871-3,'providencia 555'),
(next value for secuencia_proveedor,'ahorron',16493441,'proveedor con establecimiento en el centro de santiago','ahorron@gmail.cl',1,654891324-8,'cumminng 2854')

insert into pedido_cabecera
values
(next value for secuencia_pedido, convert(date, sysdatetime()),null,50000,96715552,1),
(next value for secuencia_pedido, convert(date, sysdatetime()),null,60000,98054979,3)
go

insert into producto
values
(next value for secuencia_producto,11590,'Lubricante Sintetico 5W-30 1lt','el Lubricante Sintetico 5W-30 1lt es lo mejor que encontrará en el mercado de lubricantes',4,1,10),
(next value for secuencia_producto,35000,'Batería 55 A Derecho Positivo 315 CCA','La Batería Autobatt es una pieza clave para todo vehículo, ya que al alimentar el motor de partida',3,3,8),
(next value for secuencia_producto,5900,'Coolant anticorrosivo 1 gl bidón','El Coolant anticorrosivo Autostyleforma parte de los accesorios automóviles que previenen daños en los motores',7,3,9)

go

/*insert into producto_almacen
values 
(next value for secuencia_pro_al,1,1,5,'2020-11-02',1,null),
(next value for secuencia_pro_al,2,1,1,null,1,null),
(next value for secuencia_pro_al,3,1,6,'2021-02-03',1,null)

go*/

insert into detalle_pedido
values
(next value for secuencia_detalle_pe,5,10000,40500,9500,50000,1,1,'2020-11-02',0),
(next value for secuencia_detalle_pe,1,30000,24300,5700,30000,2,2,null,0),
(next value for secuencia_detalle_pe,6,5000,24300,5700,30000,2,3,'2021-02-03',0)
go

select*from familia_producto
go
select * from rol
go
select * from usuario_empresa
go
select * from almacen
go
select * from dia_habil
go
select * from bloque_hora
