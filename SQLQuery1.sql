create table customers
(
	customer_id int primary key identity(1,1),
	name varchar(100),
	address varchar(500),
	contact_no varchar(20)
)

create table videos
(
	video_id int primary key identity(1,1),
	video_title varchar(100),
	genre varchar(100),
	hours int,
	minutes int,
	rental_cost int,
	year_of_release int
);

create table rented_videos
(
	rvid int primary key identity(1,1),
	video_id int,
	customer_id int,
	rent_cost int,
	rented_date datetime,
	returned_date datetime,
	constraint fk_video_id foreign key(video_id) references videos(video_id),
	constraint fk_customer_id foreign key(customer_id)
	references customers(customer_id)
);

create view viewAllRentedVideo
as
select rvid, video_title, rent_cost, name, address, contact_no ,rented_date, returned_date
from rented_videos rv join videos v on rv.video_id = v.video_id
join customers c on rv.customer_id = c.customer_id;


create procedure procAllOutRentedVideo
as
select rvid, video_title, rent_cost, name, address, contact_no ,rented_date, returned_date
from rented_videos rv join videos v on rv.video_id = v.video_id
join customers c on rv.customer_id = c.customer_id
where rv.returned_date is NULL;