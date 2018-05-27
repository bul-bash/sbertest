# sbertest

написать автотест, который будет проверять следующий функционал: нахождение или ненахождение  в яндекс картинках логотипа сбербанка.
(Приоритетным инструментом для реализации является Selenium, но допускается любое решение исполнителя)

Шаги:
1)	Открыть браузер и перейти на яндекс
2)	Ввести строку поиска «Логотип сбербанка» и нажать кнопку «найти»
3)	Перейти в Яндекс.Картинки
4)	Найти количество картинок (тегов img) у которых в аттрибуте ALT есть подстрока «сбербанк»

a.	Позитивный сценарий (т.е. тест пройден), если найдена хоть одна картинка

b.	Негативный сценарий (т.е. тест не пройден), если не найдена ни одна картинка (для негативного сценария можно искомую подстроку заменить  на сбербанк12345)
