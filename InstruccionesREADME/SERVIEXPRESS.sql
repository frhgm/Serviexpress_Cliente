use master
go
create database SERVIEXPRESS
go
use SERVIEXPRESS
go

CREATE TABLE almacen (
    id_almacén   VARCHAR(10) NOT NULL,
    direccion    VARCHAR(50) NOT NULL,
    nombre       VARCHAR(20) NOT NULL,
    estado       bit NOT NULL
)

go

ALTER TABLE ALMACEN ADD constraint almacen_pk PRIMARY KEY CLUSTERED (id_almacén)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
	
go

CREATE TABLE bloque_hora (
    id_horario                    NUMERIC(10) NOT NULL,
    ficha_empleado_rut_empleado   NUMERIC(9) NOT NULL,
    dia_habil_cod_dia             NUMERIC(10) NOT NULL,
    hora_inicio                   time NOT NULL,
    hora_final                    time NOT NULL,
    disponibilidad                bit NOT NULL,
    jornada_hora                  CHAR(2)
)

go

ALTER TABLE BLOQUE_HORA ADD constraint bloque_hora_pk PRIMARY KEY CLUSTERED (id_horario)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE boleta_factura (
    n_boleta                     NUMERIC(10) NOT NULL,
    fecha_emision                DATE NOT NULL,
    nombre_cliente               VARCHAR(50) NOT NULL,
    descripcion                  VARCHAR(100) NOT NULL,
    direccion_empresa            VARCHAR(60),
    rut_empresa                  VARCHAR,
    precio_total                 NUMERIC(7) NOT NULL,
    tipo_boleta_id_tipo_boleta   NUMERIC(10) NOT NULL,
    ficha_cliente_rut_cliente    NUMERIC(9) NOT NULL,
    estado_boleta                bit NOT NULL
)

go

ALTER TABLE BOLETA_FACTURA ADD constraint boleta_factura_pk PRIMARY KEY CLUSTERED (n_boleta)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE categoria_servicio (
    id_servicio   NUMERIC(3) NOT NULL,
    descripcion   VARCHAR(20) NOT NULL
)

go

ALTER TABLE categoria_servicio ADD constraint categoria_servicio_pk PRIMARY KEY CLUSTERED (id_servicio)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
	 
go

CREATE TABLE detalle_pago_prod (
    id_detalle_pago                        NUMERIC(6) NOT NULL,
    boleta_factura_n_boleta                NUMERIC(10) NOT NULL,
    cantidad                               NUMERIC(2) NOT NULL,
    precio_unitario                        NUMERIC(7) NOT NULL,
    subtotal                               NUMERIC(7) NOT NULL,
    producto_almacen_id_producto_almacen   NUMERIC(10) NOT NULL
)

go

ALTER TABLE DETALLE_PAGO_PROD ADD constraint detalle_pago_prod_pk PRIMARY KEY CLUSTERED (id_detalle_pago)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE detalle_pago_serv (
    id_detalle_servicio       INTEGER NOT NULL,
    servicios_cod_servicio    NUMERIC(3) NOT NULL,
    boleta_factura_n_boleta   NUMERIC(10) NOT NULL,
    cantidad                  NUMERIC(1) NOT NULL,
    subtotal                  NUMERIC(7) NOT NULL
)

go

ALTER TABLE DETALLE_PAGO_SERV ADD constraint detalle_pago_serv_pk PRIMARY KEY CLUSTERED (id_detalle_servicio)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE detalle_pedido (
    id_detalle_pedido           NUMERIC(5) NOT NULL,
    cantidad                    NUMERIC(4) NOT NULL,
    valor_compra                NUMERIC(7) NOT NULL,
    subtotal                    NUMERIC(7) NOT NULL,
    iva                         bigint NOT NULL,
    total                       NUMERIC(10) NOT NULL,
    pedido_cabecera_id_pedido   NUMERIC(5) NOT NULL,
    producto_cod_prod           NUMERIC(20) NOT NULL,
	fecha_vencimiento			date,
	recivido					bit NOT NULL
)

go

ALTER TABLE DETALLE_PEDIDO ADD constraint detalle_pedido_pk PRIMARY KEY CLUSTERED (id_detalle_pedido)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE detalle_permiso (
    id_detalle         NUMERIC(3) NOT NULL,
    seccion            VARCHAR(15) NOT NULL,
    permiso            bit NOT NULL,
    modulo_id_modulo   NUMERIC(2) NOT NULL,
    rol_cod_rol        NUMERIC(1) NOT NULL
)

go

ALTER TABLE DETALLE_PERMISO ADD constraint detalle_permiso_pk PRIMARY KEY CLUSTERED (id_detalle)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE dia_habil (
    cod_dia      NUMERIC(10) NOT NULL,
    nombre_dia   VARCHAR(15) NOT NULL,
    fecha_dia    DATE NOT NULL,
    estado_dia   bit NOT NULL
)

go

ALTER TABLE DIA_HABIL ADD constraint dia_habil_pk PRIMARY KEY CLUSTERED (cod_dia)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE familia_producto (
    id_familia    NUMERIC(3) NOT NULL,
    descripcion   VARCHAR(30) NOT NULL,
    estado        bit NOT NULL
)

go

ALTER TABLE FAMILIA_PRODUCTO ADD constraint familia_producto_pk PRIMARY KEY CLUSTERED (id_familia)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE ficha_cliente (
    rut_cliente          NUMERIC(9) NOT NULL,
    nombre_cliente       VARCHAR(30) NOT NULL,
    apellido_cliente     VARCHAR(30) NOT NULL,
    telefono             NUMERIC(9) NOT NULL,
    telefono_adicional   NUMERIC(9),
    direccion            VARCHAR(50) NOT NULL,
    fecha_nacimiento     DATE NOT NULL,
    tipo_cliente         bit
)

go

ALTER TABLE FICHA_CLIENTE ADD constraint ficha_cliente_pk PRIMARY KEY CLUSTERED (rut_cliente)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE ficha_empleado (
    rut_empleado                 NUMERIC(9) NOT NULL,
    nombre_empleado              VARCHAR(30) NOT NULL,
    apellido_empleado            VARCHAR(30) NOT NULL,
    direccion                    VARCHAR(60) NOT NULL,
    telefono                     NUMERIC(9) NOT NULL,
    telefono_adicional           NUMERIC(9),
    fecha_nacimiento             DATE NOT NULL,
    usuario_empresa_id_usuario   NUMERIC(5) NOT NULL
)

go

ALTER TABLE FICHA_EMPLEADO ADD constraint ficha_empleado_pk PRIMARY KEY CLUSTERED (rut_empleado)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE marca_producto (
    id_marca      NUMERIC(10) NOT NULL,
    descripcion   VARCHAR(20) NOT NULL,
    estado        bit NOT NULL
)

go

ALTER TABLE MARCA_PRODUCTO ADD constraint marca_producto_pk PRIMARY KEY CLUSTERED (id_marca)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE modulo (
    id_modulo     NUMERIC(2) NOT NULL,
    descripcion   VARCHAR NOT NULL,
    prioridad     VARCHAR(20),
    icono         image,
    estado        bit NOT NULL
)

go

ALTER TABLE MODULO ADD constraint modulo_pk PRIMARY KEY CLUSTERED (id_modulo)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE pedido_cabecera (
    id_pedido                     NUMERIC(5) NOT NULL,
    fecha_emision                 DATE NOT NULL,
    fecha_recepcion               DATE ,
    total                         NUMERIC(10) NOT NULL,
    ficha_empleado_rut_empleado   NUMERIC(9) NOT NULL,
    proveedor_id_proveedor        NUMERIC(3) NOT NULL
)

go

ALTER TABLE PEDIDO_CABECERA ADD constraint pedido_cabecera_pk PRIMARY KEY CLUSTERED (id_pedido)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE producto (
    cod_prod                      NUMERIC(20) NOT NULL,
    precio_unitario               VARCHAR(7) NOT NULL,
    nombre_producto               VARCHAR(50) NOT NULL,
    descripcion                   VARCHAR(800) NOT NULL,
    familia_producto_id_familia   NUMERIC(3) NOT NULL,
    proveedor_id_proveedor        NUMERIC(3) NOT NULL,
    marca_producto_id_marca       NUMERIC(10) NOT NULL

)

go

ALTER TABLE PRODUCTO ADD constraint producto_pk PRIMARY KEY CLUSTERED (cod_prod)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE producto_almacen (
    id_producto_almacen   NUMERIC(10) NOT NULL,
    producto_cod_prod     NUMERIC(20) NOT NULL,
    almacen_id_almacén    VARCHAR(10) NOT NULL,
    stock                 NUMERIC(3) NOT NULL,
	fecha_vencimiento	  date,
    estado                bit NOT NULL,
	codificacion          VARCHAR(18)
)

go

ALTER TABLE PRODUCTO_ALMACEN ADD constraint producto_almacen_pk PRIMARY KEY CLUSTERED (id_producto_almacen)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE proveedor (
    id_proveedor         NUMERIC(3) NOT NULL,
    nombre               VARCHAR(20) NOT NULL,
    n_contacto           NUMERIC(9) NOT NULL,
    descripcion          VARCHAR(60) NOT NULL,
    email                VARCHAR(30) NOT NULL,
    estado               bit NOT NULL,
    rut_proveedor        VARCHAR(20) NOT NULL,
    direccion            VARCHAR(50) NOT NULL
)

go

ALTER TABLE PROVEEDOR ADD constraint proveedor_pk PRIMARY KEY CLUSTERED (id_proveedor)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE reserva (
    n_reserva                     NUMERIC(10) NOT NULL,
    fecha                         DATE NOT NULL,
    hora                          NUMERIC(4) NOT NULL,
    patente                       VARCHAR(6) NOT NULL,
    marca                         VARCHAR(50) NOT NULL,
    modelo                        VARCHAR(50) NOT NULL,
    anno_vehiculo                 NUMERIC(4) NOT NULL,
    descripcion_vehiculo          VARCHAR(100),
    ficha_cliente_rut_cliente     NUMERIC(9) NOT NULL,
    servicios_cod_servicio        NUMERIC(3) NOT NULL,
    ficha_empleado_rut_empleado   NUMERIC(9) NOT NULL,
    bloque_hora_id_horario        NUMERIC(10) NOT NULL,
    estado_reserva                bit
)

go

ALTER TABLE RESERVA ADD constraint reserva_pk PRIMARY KEY CLUSTERED (n_reserva)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE rol (
    cod_rol   NUMERIC(1) NOT NULL,
    nombre    VARCHAR(25) NOT NULL
)

go

ALTER TABLE ROL ADD constraint rol_pk PRIMARY KEY CLUSTERED (cod_rol)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE servicios (
    cod_servicio                     NUMERIC(3) NOT NULL,
    descripcion                      VARCHAR(40) NOT NULL,
    tarifa                           VARCHAR(10) NOT NULL,
    estado                           bit NOT NULL,
    nombre                           VARCHAR(30) NOT NULL,
    categoria_servicio_id_servicio   NUMERIC(3) NOT NULL
)

go

ALTER TABLE SERVICIOS ADD constraint servicios_pk PRIMARY KEY CLUSTERED (cod_servicio)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE tipo_boleta (
    id_tipo_boleta   NUMERIC(10) NOT NULL,
    descripcion      VARCHAR(20) NOT NULL
)

go

ALTER TABLE TIPO_BOLETA ADD constraint tipo_boleta_pk PRIMARY KEY CLUSTERED (id_tipo_boleta)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE usuario_cliente (
    id_usuario                  INTEGER NOT NULL,
    ficha_cliente_rut_cliente   NUMERIC(9) NOT NULL,
    estado                      bit NOT NULL
)

go

ALTER TABLE USUARIO_CLIENTE ADD constraint usuario_cliente_pk PRIMARY KEY CLUSTERED (id_usuario)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

CREATE TABLE usuario_empresa (
    id_usuario           NUMERIC(5) NOT NULL,
    correo_electronico   VARCHAR(50) NOT NULL,
    password             VARCHAR(20) NOT NULL,
    fecha_creacion       DATE NOT NULL,
    estado               bit NOT NULL,
    rol_cod_rol          NUMERIC(1) NOT NULL
)
go

ALTER TABLE USUARIO_EMPRESA ADD constraint usuario_empresa_pk PRIMARY KEY CLUSTERED (id_usuario)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
go

ALTER TABLE BLOQUE_HORA
    ADD CONSTRAINT bloque_hora_dia_habil_fk FOREIGN KEY ( dia_habil_cod_dia )
        REFERENCES dia_habil ( cod_dia )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE BLOQUE_HORA
    ADD CONSTRAINT bloque_hora_ficha_empleado_fk FOREIGN KEY ( ficha_empleado_rut_empleado )
        REFERENCES ficha_empleado ( rut_empleado )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE BOLETA_FACTURA
    ADD CONSTRAINT boleta_factura_ficha_cliente_fk FOREIGN KEY ( ficha_cliente_rut_cliente )
        REFERENCES ficha_cliente ( rut_cliente )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE BOLETA_FACTURA
    ADD CONSTRAINT boleta_factura_tipo_boleta_fk FOREIGN KEY ( tipo_boleta_id_tipo_boleta )
        REFERENCES tipo_boleta ( id_tipo_boleta )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE DETALLE_PAGO_PROD
    ADD CONSTRAINT detalle_pago_prod_boleta_factura_fk FOREIGN KEY ( boleta_factura_n_boleta )
        REFERENCES boleta_factura ( n_boleta )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE DETALLE_PAGO_PROD
    ADD CONSTRAINT detalle_pago_prod_producto_almacen_fk FOREIGN KEY ( producto_almacen_id_producto_almacen )
        REFERENCES producto_almacen ( id_producto_almacen )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE DETALLE_PAGO_SERV
    ADD CONSTRAINT detalle_pago_serv_boleta_factura_fk FOREIGN KEY ( boleta_factura_n_boleta )
        REFERENCES boleta_factura ( n_boleta )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE DETALLE_PAGO_SERV
    ADD CONSTRAINT detalle_pago_serv_servicios_fk FOREIGN KEY ( servicios_cod_servicio )
        REFERENCES servicios ( cod_servicio )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE DETALLE_PEDIDO
    ADD CONSTRAINT detalle_pedido_pedido_cabecera_fk FOREIGN KEY ( pedido_cabecera_id_pedido )
        REFERENCES pedido_cabecera ( id_pedido )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE DETALLE_PEDIDO
    ADD CONSTRAINT detalle_pedido_producto_fk FOREIGN KEY ( producto_cod_prod )
        REFERENCES producto ( cod_prod )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE DETALLE_PERMISO
    ADD CONSTRAINT detalle_permiso_modulo_fk FOREIGN KEY ( modulo_id_modulo )
        REFERENCES modulo ( id_modulo )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE DETALLE_PERMISO
    ADD CONSTRAINT detalle_permiso_rol_fk FOREIGN KEY ( rol_cod_rol )
        REFERENCES rol ( cod_rol )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE FICHA_EMPLEADO
    ADD CONSTRAINT ficha_empleado_usuario_empresa_fk FOREIGN KEY ( usuario_empresa_id_usuario )
        REFERENCES usuario_empresa ( id_usuario )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE PEDIDO_CABECERA
    ADD CONSTRAINT pedido_cabecera_ficha_empleado_fk FOREIGN KEY ( ficha_empleado_rut_empleado )
        REFERENCES ficha_empleado ( rut_empleado )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE PEDIDO_CABECERA
    ADD CONSTRAINT pedido_cabecera_proveedor_fk FOREIGN KEY ( proveedor_id_proveedor )
        REFERENCES proveedor ( id_proveedor )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE PRODUCTO_ALMACEN
    ADD CONSTRAINT producto_almacen_almacen_fk FOREIGN KEY ( almacen_id_almacén )
        REFERENCES almacen ( id_almacén )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE PRODUCTO_ALMACEN
    ADD CONSTRAINT producto_almacen_producto_fk FOREIGN KEY ( producto_cod_prod )
        REFERENCES producto ( cod_prod )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE PRODUCTO
    ADD CONSTRAINT producto_familia_producto_fk FOREIGN KEY ( familia_producto_id_familia )
        REFERENCES familia_producto ( id_familia )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE PRODUCTO
    ADD CONSTRAINT producto_marca_producto_fk FOREIGN KEY ( marca_producto_id_marca )
        REFERENCES marca_producto ( id_marca )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE PRODUCTO
    ADD CONSTRAINT producto_proveedor_fk FOREIGN KEY ( proveedor_id_proveedor )
        REFERENCES proveedor ( id_proveedor )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE RESERVA
    ADD CONSTRAINT reserva_bloque_hora_fk FOREIGN KEY ( bloque_hora_id_horario )
        REFERENCES bloque_hora ( id_horario )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE RESERVA
    ADD CONSTRAINT reserva_ficha_cliente_fk FOREIGN KEY ( ficha_cliente_rut_cliente )
        REFERENCES ficha_cliente ( rut_cliente )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE RESERVA
    ADD CONSTRAINT reserva_ficha_empleado_fk FOREIGN KEY ( ficha_empleado_rut_empleado )
        REFERENCES ficha_empleado ( rut_empleado )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE RESERVA
    ADD CONSTRAINT reserva_servicios_fk FOREIGN KEY ( servicios_cod_servicio )
        REFERENCES servicios ( cod_servicio )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE SERVICIOS
    ADD CONSTRAINT servicios_categoria_servicio_fk FOREIGN KEY ( categoria_servicio_id_servicio )
        REFERENCES categoria_servicio ( id_servicio )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE USUARIO_CLIENTE
    ADD CONSTRAINT usuario_cliente_ficha_cliente_fk FOREIGN KEY ( ficha_cliente_rut_cliente )
        REFERENCES ficha_cliente ( rut_cliente )
ON DELETE NO ACTION 
    ON UPDATE no action 
go

ALTER TABLE USUARIO_EMPRESA
    ADD CONSTRAINT usuario_empresa_rol_fk FOREIGN KEY ( rol_cod_rol )
        REFERENCES rol ( cod_rol )
ON DELETE NO ACTION 
    ON UPDATE no action 
go
