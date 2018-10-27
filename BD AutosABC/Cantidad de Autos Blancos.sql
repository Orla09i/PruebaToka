SELECT A.Marca, A.Modelo, COUNT(A.Color) as Cantidad
FROM AUTOS as A
WHERE A.Color = 'Blanco'
GROUP BY A.Marca, A.Modelo
ORDER BY COUNT(A.Folio)

