DROP TABLE usuario
DROP TABLE restaurant
DROP TABLE comida
DROP TABLE categoria_comida
DROP TABLE menu
DROP TABLE pedido

CREATE TABLE  usuario
(
    nombre character varying(20) COLLATE pg_catalog."default" NOT NULL,
    edad integer NOT NULL,
    tipo character varying(1) COLLATE pg_catalog."default" NOT NULL,
    usuario character varying(20) COLLATE pg_catalog."default" NOT NULL,
    passw character varying(30) COLLATE pg_catalog."default" NOT NULL,
    dinero integer,
    CONSTRAINT usuario_pkey PRIMARY KEY (usuario)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE  usuario
    OWNER to postgres;

GRANT ALL ON TABLE  usuario TO postgres;

GRANT ALL ON TABLE  usuario TO PUBLIC;

CREATE TABLE  restaurant
(
    nombre character varying(30) COLLATE pg_catalog."default" NOT NULL,
    direccion character varying(50) COLLATE pg_catalog."default" NOT NULL,
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    CONSTRAINT restaurant_pkey PRIMARY KEY (id)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE  restaurant
    OWNER to postgres;

GRANT ALL ON TABLE  restaurant TO postgres;

GRANT ALL ON TABLE  restaurant TO PUBLIC;

CREATE TABLE  comida
(
    nombre character varying(50) COLLATE pg_catalog."default" NOT NULL,
    categoria integer NOT NULL,
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    CONSTRAINT comida_pkey PRIMARY KEY (id),
    CONSTRAINT categoria FOREIGN KEY (categoria)
        REFERENCES  categoria_comida (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE  comida
    OWNER to postgres;

GRANT ALL ON TABLE  comida TO postgres;

GRANT ALL ON TABLE  comida TO PUBLIC;

CREATE TABLE  categoria_comida
(
    nombre character varying(20) COLLATE pg_catalog."default",
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    CONSTRAINT categoria_comida_pkey PRIMARY KEY (id)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE  categoria_comida
    OWNER to postgres;

GRANT ALL ON TABLE  categoria_comida TO postgres;

GRANT ALL ON TABLE  categoria_comida TO PUBLIC;

CREATE TABLE  menu
(
    restaurant integer NOT NULL,
    comida integer NOT NULL,
    precio integer NOT NULL,
    CONSTRAINT comida FOREIGN KEY (comida)
        REFERENCES  comida (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT restaurant FOREIGN KEY (restaurant)
        REFERENCES  restaurant (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE  menu
    OWNER to postgres;

GRANT ALL ON TABLE  menu TO postgres;

GRANT ALL ON TABLE  menu TO PUBLIC;

CREATE TABLE  pedido
(
    cliente character varying(20) COLLATE pg_catalog."default" NOT NULL,
    detalle character varying(300) COLLATE pg_catalog."default" NOT NULL,
    monto integer NOT NULL,
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    CONSTRAINT cliente FOREIGN KEY (cliente)
        REFERENCES  usuario (usuario) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE  pedido
    OWNER to postgres;

GRANT ALL ON TABLE  pedido TO postgres;

GRANT ALL ON TABLE  pedido TO PUBLIC;


--No se agrega el campo id al hacer inserts ya que es incrementa
INSERT INTO usuario(nombre, edad, tipo, usuario, passw)VALUES ( 'Elías', 21, 'A', 'elias1', 1234);
INSERT INTO usuario(nombre, edad, tipo, usuario, passw )VALUES ( 'Sebastián', 20, 'A', 'sebastian1', 1234);
INSERT INTO usuario(nombre, edad, tipo, usuario, passw )VALUES ( 'Bruno', 21, 'A', 'bruno1', 1234);

INSERT INTO usuario(nombre, edad, tipo, usuario, passw, dinero)VALUES ( 'Pablo', 24, 'U', 'pablo1', 1234,15000);

INSERT INTO restaurant(nombre, direccion) VALUES ('Mcdonalds','Avenida Central'); --1
INSERT INTO restaurant(nombre, direccion) VALUES ('Pizza Hut','Avenida Central'); --2
INSERT INTO restaurant(nombre, direccion) VALUES ('Taco Bell','Avenida Central'); --3
INSERT INTO restaurant(nombre, direccion) VALUES ('Olive Garden','Santa Ana'); --4 
INSERT INTO restaurant(nombre, direccion) VALUES ('Novillo Alegre','Curridabat'); --5
INSERT INTO restaurant(nombre, direccion) VALUES ('Outback Steakhouse','Escazú'); --6 


INSERT INTO categoria_comida(nombre) VALUES ('Gourmet Food');
INSERT INTO categoria_comida(nombre) VALUES ('Fast Food');
INSERT INTO categoria_comida(nombre) VALUES ('Bebidas');
INSERT INTO categoria_comida(nombre) VALUES ('Postres');
INSERT INTO categoria_comida(nombre) VALUES ('Ensaladas');

--McDonalds
INSERT INTO comida(nombre, categoria) VALUES ('BigMac',2);
INSERT INTO comida(nombre, categoria) VALUES ('Pollo Frito',2);
INSERT INTO comida(nombre, categoria) VALUES ('Ensalada',5);
INSERT INTO comida(nombre, categoria) VALUES ('Coca Cola',3);
INSERT INTO comida(nombre, categoria) VALUES ('Pie de manzana',4);

INSERT INTO menu(restaurant, comida, precio) VALUES (1, 1, 4500);
INSERT INTO menu(restaurant, comida, precio) VALUES (1, 2, 3500);
INSERT INTO menu(restaurant, comida, precio) VALUES (1, 3, 5000);
INSERT INTO menu(restaurant, comida, precio) VALUES (1, 4, 1800);
INSERT INTO menu(restaurant, comida, precio) VALUES (1, 5, 1200);

--Pizza Hut
INSERT INTO comida(nombre, categoria) VALUES ('Pizza jamón y queso',2);
INSERT INTO comida(nombre, categoria) VALUES ('Spaghetti con carne molida',2);
INSERT INTO comida(nombre, categoria) VALUES ('Breadsticks',2);
INSERT INTO comida(nombre, categoria) VALUES ('Fanta Naranja',3);
INSERT INTO comida(nombre, categoria) VALUES ('Helado',4);

INSERT INTO menu(restaurant, comida, precio) VALUES (2, 1, 9990);
INSERT INTO menu(restaurant, comida, precio) VALUES (2, 2, 5700);
INSERT INTO menu(restaurant, comida, precio) VALUES (2, 3, 3200);
INSERT INTO menu(restaurant, comida, precio) VALUES (2, 4, 1700);
INSERT INTO menu(restaurant, comida, precio) VALUES (2, 5, 1100);

--Taco Bell
INSERT INTO comida(nombre, categoria) VALUES ('Burrito',2);
INSERT INTO comida(nombre, categoria) VALUES ('Quesadilla',2);
INSERT INTO comida(nombre, categoria) VALUES ('Papas fritas',2);
INSERT INTO comida(nombre, categoria) VALUES ('Root Beer',3);
INSERT INTO comida(nombre, categoria) VALUES ('Flauta de caramelo',4);

INSERT INTO menu(restaurant, comida, precio) VALUES (3, 1, 3200);
INSERT INTO menu(restaurant, comida, precio) VALUES (3, 2, 4300);
INSERT INTO menu(restaurant, comida, precio) VALUES (3, 3, 2550);
INSERT INTO menu(restaurant, comida, precio) VALUES (3, 4, 1900);
INSERT INTO menu(restaurant, comida, precio) VALUES (3, 5, 800);

--Olive Garden
INSERT INTO comida(nombre, categoria) VALUES ('Focaccia',1);
INSERT INTO comida(nombre, categoria) VALUES ('Raviolis',1);
INSERT INTO comida(nombre, categoria) VALUES ('Pizza Margherita',1);
INSERT INTO comida(nombre, categoria) VALUES ('Limonada con hierbabuena',3);
INSERT INTO comida(nombre, categoria) VALUES ('Faggoto de nutella',4);

INSERT INTO menu(restaurant, comida, precio) VALUES (4, 1, 7500);
INSERT INTO menu(restaurant, comida, precio) VALUES (4, 2, 10500);
INSERT INTO menu(restaurant, comida, precio) VALUES (4, 3, 12500);
INSERT INTO menu(restaurant, comida, precio) VALUES (4, 4, 2800);
INSERT INTO menu(restaurant, comida, precio) VALUES (4, 5, 3500);

--Novillo Alegre
INSERT INTO comida(nombre, categoria) VALUES ('Tomahawk Steak',1);
INSERT INTO comida(nombre, categoria) VALUES ('Salmon',1);
INSERT INTO comida(nombre, categoria) VALUES ('Tartar de atún',1);
INSERT INTO comida(nombre, categoria) VALUES ('Vino',3);
INSERT INTO comida(nombre, categoria) VALUES ('Tiramisú',4);

INSERT INTO menu(restaurant, comida, precio) VALUES (5, 1, 29990);
INSERT INTO menu(restaurant, comida, precio) VALUES (5, 2, 15800);
INSERT INTO menu(restaurant, comida, precio) VALUES (5, 3, 7700);
INSERT INTO menu(restaurant, comida, precio) VALUES (5, 4, 4000);
INSERT INTO menu(restaurant, comida, precio) VALUES (5, 5, 5990);

--Outback Steakhouse
INSERT INTO comida(nombre, categoria) VALUES ('New York Steak',1);
INSERT INTO comida(nombre, categoria) VALUES ('Alitas',2);
INSERT INTO comida(nombre, categoria) VALUES ('Smokehouse Burger',2);
INSERT INTO comida(nombre, categoria) VALUES ('Heineken',3);
INSERT INTO comida(nombre, categoria) VALUES ('Cheese cake',4);

INSERT INTO menu(restaurant, comida, precio) VALUES (6, 1, 10990);
INSERT INTO menu(restaurant, comida, precio) VALUES (6, 2, 8500);
INSERT INTO menu(restaurant, comida, precio) VALUES (6, 3, 7900);
INSERT INTO menu(restaurant, comida, precio) VALUES (6, 4, 2900);
INSERT INTO menu(restaurant, comida, precio) VALUES (6, 5, 3450);

--Pedido
INSERT INTO pedido(cliente, detalle, monto) VALUES ( 'pablo1', '-Hamburguesa: 2500 -Burrito:2500',2500 );
