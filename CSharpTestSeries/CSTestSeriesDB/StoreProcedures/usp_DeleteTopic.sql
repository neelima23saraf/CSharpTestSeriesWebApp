
create procedure [dbo].[DeleteTopic]
    @id int
as
begin
	delete from topics where id = @id
end
