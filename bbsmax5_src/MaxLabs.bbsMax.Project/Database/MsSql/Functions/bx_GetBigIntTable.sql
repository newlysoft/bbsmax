﻿--根据一个字符串得到BigInt内存表
EXEC bx_Drop 'bx_GetBigIntTable';

GO

CREATE FUNCTION [bx_GetBigIntTable]
(
	@text varchar(8000),
	@separator varchar(2) = ','
)
RETURNS @ItemTable TABLE 
(
	 id   bigint IDENTITY(1, 1) 
	,item int
)
AS
BEGIN

	IF (@text = '')
		RETURN;

	INSERT @ItemTable
	SELECT SUBSTRING(@text, I ,CHARINDEX(@separator, @text + @separator, I) - I)   
	FROM [bx_Identities_8000] WITH (NOLOCK)
	WHERE I <= LEN(@text) + 1 AND CHARINDEX(@separator, @separator + @text, I) - I = 0   

	RETURN;

END

GO