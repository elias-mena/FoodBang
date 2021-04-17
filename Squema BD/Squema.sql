DROP TABLE usuario
DROP TABLE restaurant
DROP TABLE comida
DROP TABLE categoria_comida
DROP TABLE menu
DROP TABLE pedido

CREATE TABLE usuario
(
    nombre character varying(20) COLLATE pg_catalog."default" NOT NULL,
    edad integer NOT NULL,
    tipo character varying(1) COLLATE pg_catalog."default" NOT NULL,
    usuario character varying(20) COLLATE pg_catalog."default" NOT NULL,
    passw character varying(30) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT usuario_pkey PRIMARY KEY (usuario)
)

CREATE TABLE restaurant
(
    nombre character varying(30) COLLATE pg_catalog."default" NOT NULL,
    direccion character varying(50) COLLATE pg_catalog."default" NOT NULL,
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    CONSTRAINT restaurant_pkey PRIMARY KEY (id)
)

CREATE TABLE comida
(
    nombre character varying(20) COLLATE pg_catalog."default" NOT NULL,
    categoria integer NOT NULL,
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    CONSTRAINT "Comida_pkey" PRIMARY KEY (id),
    CONSTRAINT comida_categoria FOREIGN KEY (categoria)
        REFERENCES public.categoria_comida (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

CREATE TABLE categoria_comida
(
    nombre character varying COLLATE pg_catalog."default" NOT NULL,
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    CONSTRAINT categoria_comida_pkey PRIMARY KEY (id)
)

CREATE TABLE menu
(
    restaurant integer NOT NULL,
    comida integer NOT NULL,
    precio integer NOT NULL,
    CONSTRAINT menu_pkey PRIMARY KEY (comida, restaurant),
    CONSTRAINT comida FOREIGN KEY (comida)
        REFERENCES public.comida (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT restaurant FOREIGN KEY (restaurant)
        REFERENCES public.restaurant (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

CREATE TABLE pedido
(
    cliente character varying(20) COLLATE pg_catalog."default" NOT NULL,
    detalle character varying(300) COLLATE pg_catalog."default" NOT NULL,
    monto integer NOT NULL,
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    CONSTRAINT pedido_pkey PRIMARY KEY (id)
)

--No se agrega el campo id al hacer inserts ya que es incremental

INSERT INTO usuario(nombre, edad, tipo, usuario, passw)VALUES ( 'Elías', 21, 'A', 'elias1', 1234);
INSERT INTO usuario(nombre, edad, tipo, usuario, passw)VALUES ( 'Sebastián', 20, 'A', 'sebastian1', 1234);
INSERT INTO usuario(nombre, edad, tipo, usuario, passw)VALUES ( 'Bruno', 21, 'A', 'bruno1', 1234);

INSERT INTO usuario(nombre, edad, tipo, usuario, passw)VALUES ( 'Pablo', 24, 'U', 'pablo1', 1234);

INSERT INTO restaurant(nombre, direccion) VALUES ( 'Mcdonalds','Avenida Central');
INSERT INTO restaurant(nombre, direccion) VALUES ( 'Subway','Avenida Central');
INSERT INTO restaurant(nombre, direccion) VALUES ( 'Pizza Hut','Avenida Central');

INSERT INTO categoria_comida(nombre) VALUES ('Comida Rápida');
INSERT INTO categoria_comida(nombre) VALUES ('Comida China');
INSERT INTO categoria_comida(nombre) VALUES ('Comida Tradicional');
INSERT INTO categoria_comida(nombre) VALUES ('Comida Saludable');
INSERT INTO categoria_comida(nombre) VALUES ('Bebidas');

INSERT INTO comida(nombre, categoria) VALUES ( 'Hamburguesa',1);
INSERT INTO comida(nombre, categoria) VALUES ( 'Arroz Cantonés',2);
INSERT INTO comida(nombre, categoria) VALUES ( 'Gallo Pinto',3);
INSERT INTO comida(nombre, categoria) VALUES ( 'Burrito',1);

INSERT INTO menu(restaurant, comida, precio) VALUES ( 1, 1, 2500);

INSERT INTO pedido(cliente, detalle, monto) VALUES ( 'pablo1', '-Hamburguesa: 2500 -Burrito:2500',2500 );