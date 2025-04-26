begin  transaction
insert into Admin (Admin_id,Admin_email,Admin_name,Admin_password) values
('2','fdfa@gmail.com','omar','32');
rollback;
select * from dbo.Admin;