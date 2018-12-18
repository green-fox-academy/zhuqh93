ALTER TABLE tblEpisode
ADD NumberEnemies int
--
ALTER TABLE tblEpisode
DROP COLUMN NumberEnemies

--

BEGIN TRAN;
--
UPDATE tblEpisode
SET NumberEnemies = (
SELECT COUNT(*)
FROM tblEpisodeEnemy AS ee
WHERE ee.EpisodeId = e.EpisodeId)
FROM tblEpisode AS e;
--
DECLARE @affectedRows2 int = @@ROWCOUNT
IF @affectedRows2 > 120
	BEGIN
		SELECT CAST(@affectedRows2 AS VARCHAR) + N' rows are updated, but change rolled back';
		ROLLBACK TRAN;
	END
ELSE
	BEGIN
		SELECT * FROM tblEpisode;
	END
