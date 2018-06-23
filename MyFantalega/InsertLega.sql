INSERT dbo.Lega
(
    nome,
    numSquadreTot,
    creditiIniziali,
    numPor,
    numDif,
    numCen,
    numAtt,
    squadraAdmin,
    lista,
    legaAdmin
)
VALUES
(   'LigaCspt', -- nome - varchar(20)
    4,  -- numSquadreTot - int
    500,  -- creditiIniziali - int
    3,  -- numPor - int
    8,  -- numDif - int
    8,  -- numCen - int
    6,  -- numAtt - int
    NULL, -- squadraAdmin - varchar(40)
    NULL,  -- lista - int
    NULL  -- legaAdmin - varchar(20)
    )