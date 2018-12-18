DELETE FROM tblEvent WHERE EventName LIKE 'My DOB'

SELECT * FROM tblEvent

BEGIN TRAN
--
IF NOT EXISTS(SELECT * FROM tblEvent WHERE EventName LIKE 'My DOB')
	BEGIN
		INSERT INTO tblEvent(EventName, EventDetails, EventDate)
		VALUES('My DOB', 'I was born and the world trembles.', '1993-03-03');
		SELECT N'This momentous event has now been added' AS EventResults;
		COMMIT TRAN;
	END
ELSE
	BEGIN
		SELECT N'The magnificent event already exists' AS EventResults;
	END