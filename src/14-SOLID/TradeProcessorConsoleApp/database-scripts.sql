 create database TradeDatabase
 go
 use TradeDatabase
 go

create table trades(
	sourceCurrency varchar(100),
	destinationCurrency varchar(100),
	lots float,
	price decimal
)

go
create procedure insert_trade
	@sourceCurrency varchar(100),
	@destinationCurrency varchar(100),
	@lots float,
	@price decimal
as
begin
	insert into trades(sourceCurrency,destinationCurrency, lots,price)
	values( @sourceCurrency,@destinationCurrency, @lots,@price)
end