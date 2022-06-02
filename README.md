# DepositCalculator
Приложение имеет возможность ввода суммы и срока(количество месяцев), а также выбора метода выплаты процентов (капитализация или выплата помесячно) и валюты.

Формула расчета вклада с капитализацией процентов:

![image](https://user-images.githubusercontent.com/106742029/171718718-4197b36c-d685-4cb6-ba6b-5f6ada537a1f.png)

где ![image](https://user-images.githubusercontent.com/106742029/171719371-ec8acde6-597c-437a-a03b-32ab27c2f46c.png) — величина дохода, ![image](https://user-images.githubusercontent.com/106742029/171719431-a6f3c2b2-3022-47d0-81b8-520055b7b834.png) — сумма вклада, ![image](https://user-images.githubusercontent.com/106742029/171719500-0c2aede1-b8f1-49d5-b7f4-b7894c2c58ff.png) — сумма, возвращаемая вкладчику по окончании срока, ![image](https://user-images.githubusercontent.com/106742029/171719552-f72c82e6-107c-4179-8127-228ca5ae5a13.png) — нормированная величина годовой процентной ставки, ![image](https://user-images.githubusercontent.com/106742029/171719616-d6cb75e6-f007-4a75-ab31-5589094c7d79.png) — количество периодов начисления процентов за полный год, ![image](https://user-images.githubusercontent.com/106742029/171719671-ed166e7e-6224-43fe-9d48-d09636069f34.png) — срок вклада в годах.


Формула расчета вклада без капитализации процентов:

![image](https://user-images.githubusercontent.com/106742029/171719887-22a4084b-dbcd-42e4-9278-65cfc72e3a38.png)


где ![image](https://user-images.githubusercontent.com/106742029/171719371-ec8acde6-597c-437a-a03b-32ab27c2f46c.png) — величина дохода, ![image](https://user-images.githubusercontent.com/106742029/171719431-a6f3c2b2-3022-47d0-81b8-520055b7b834.png) — сумма вклада (тело депозита), ![image](https://user-images.githubusercontent.com/106742029/171719500-0c2aede1-b8f1-49d5-b7f4-b7894c2c58ff.png) — сумма, возвращаемая вкладчику по окончании срока (в случае, если проценты выплачиваются в конце срока), ![image](https://user-images.githubusercontent.com/106742029/171719552-f72c82e6-107c-4179-8127-228ca5ae5a13.png) — нормированная величина годовой процентной ставки, ![image](https://user-images.githubusercontent.com/106742029/171719671-ed166e7e-6224-43fe-9d48-d09636069f34.png) — срок вклада в месяцах.
