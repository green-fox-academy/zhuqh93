CREATE PROCEDURE MakeNewOrder
	@basketItemId bigint,
	@goodId bigint,
	@basketId bigint
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			IF (SELECT Stock FROM Goods WHERE GoodId = @goodId) >= (SELECT Quantity FROM BasketItem WHERE BasketItemId = @basketItemId)
				UPDATE Goods SET Stock = Stock - (SELECT Quantity FROM BasketItem WHERE BasketItemId = @basketItemId);
			
			COMMIT
		END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END