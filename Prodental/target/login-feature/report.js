$(document).ready(function() {var formatter = new CucumberHTML.DOMFormatter($('.cucumber-report'));formatter.uri("uni/fmi/calendar/Calendar.feature");
formatter.feature({
  "line": 1,
  "name": "Валидиране на чaс в календар",
  "description": "",
  "id": "валидиране-на-чaс-в-календар",
  "keyword": "Feature"
});
formatter.background({
  "line": 3,
  "name": "",
  "description": "",
  "type": "background",
  "keyword": "Background"
});
formatter.step({
  "line": 4,
  "name": "Потребителят отваря екрана за запазване на час",
  "keyword": "Given "
});
formatter.match({
  "location": "CalendarBookingSteps.openBookingScreen()"
});
formatter.result({
  "duration": 89809000,
  "status": "passed"
});
formatter.scenario({
  "line": 6,
  "name": "Запазване на час при зъболекар с верни данни",
  "description": "",
  "id": "валидиране-на-чaс-в-календар;запазване-на-час-при-зъболекар-с-верни-данни",
  "type": "scenario",
  "keyword": "Scenario"
});
formatter.step({
  "line": 7,
  "name": "Въведе \"gerity59@gmail.com\" е-поща",
  "keyword": "When "
});
formatter.step({
  "line": 8,
  "name": "избере дата \"2022-02-20\"",
  "keyword": "And "
});
formatter.step({
  "line": 9,
  "name": "избере час \"10:15\"",
  "keyword": "And "
});
formatter.step({
  "line": 10,
  "name": "и натисне бутона за запазване на час",
  "keyword": "And "
});
formatter.step({
  "line": 11,
  "name": "Вижда съобщение \"Успешно запазихте час!\"",
  "keyword": "Then "
});
formatter.match({
  "arguments": [
    {
      "val": "gerity59@gmail.com",
      "offset": 8
    }
  ],
  "location": "CalendarBookingSteps.addEmail(String)"
});
formatter.result({
  "duration": 2389700,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "2022-02-20",
      "offset": 13
    }
  ],
  "location": "CalendarBookingSteps.addDate(String)"
});
formatter.result({
  "duration": 92300,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "10:15",
      "offset": 12
    }
  ],
  "location": "CalendarBookingSteps.addHour(String)"
});
formatter.result({
  "duration": 90800,
  "status": "passed"
});
formatter.match({
  "location": "CalendarBookingSteps.clickReserveBtn()"
});
formatter.result({
  "duration": 68570000,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "Успешно запазихте час!",
      "offset": 17
    }
  ],
  "location": "CalendarBookingSteps.checkMessage(String)"
});
formatter.result({
  "duration": 1604100,
  "status": "passed"
});
formatter.background({
  "line": 3,
  "name": "",
  "description": "",
  "type": "background",
  "keyword": "Background"
});
formatter.step({
  "line": 4,
  "name": "Потребителят отваря екрана за запазване на час",
  "keyword": "Given "
});
formatter.match({
  "location": "CalendarBookingSteps.openBookingScreen()"
});
formatter.result({
  "duration": 34100,
  "status": "passed"
});
formatter.scenario({
  "line": 14,
  "name": "Запазване на час при зъболекар с невалиден имейл",
  "description": "",
  "id": "валидиране-на-чaс-в-календар;запазване-на-час-при-зъболекар-с-невалиден-имейл",
  "type": "scenario",
  "keyword": "Scenario"
});
formatter.step({
  "line": 15,
  "name": "Въведе \"invalidemail\" е-поща",
  "keyword": "When "
});
formatter.step({
  "line": 16,
  "name": "избере дата \"2022-02-20\"",
  "keyword": "And "
});
formatter.step({
  "line": 17,
  "name": "избере час \"10:15\"",
  "keyword": "And "
});
formatter.step({
  "line": 18,
  "name": "и натисне бутона за запазване на час",
  "keyword": "And "
});
formatter.step({
  "line": 19,
  "name": "Вижда съобщение \"Въведете валиден имейл!\"",
  "keyword": "Then "
});
formatter.match({
  "arguments": [
    {
      "val": "invalidemail",
      "offset": 8
    }
  ],
  "location": "CalendarBookingSteps.addEmail(String)"
});
formatter.result({
  "duration": 73700,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "2022-02-20",
      "offset": 13
    }
  ],
  "location": "CalendarBookingSteps.addDate(String)"
});
formatter.result({
  "duration": 142600,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "10:15",
      "offset": 12
    }
  ],
  "location": "CalendarBookingSteps.addHour(String)"
});
formatter.result({
  "duration": 57800,
  "status": "passed"
});
formatter.match({
  "location": "CalendarBookingSteps.clickReserveBtn()"
});
formatter.result({
  "duration": 66300,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "Въведете валиден имейл!",
      "offset": 17
    }
  ],
  "location": "CalendarBookingSteps.checkMessage(String)"
});
formatter.result({
  "duration": 64200,
  "status": "passed"
});
formatter.background({
  "line": 3,
  "name": "",
  "description": "",
  "type": "background",
  "keyword": "Background"
});
formatter.step({
  "line": 4,
  "name": "Потребителят отваря екрана за запазване на час",
  "keyword": "Given "
});
formatter.match({
  "location": "CalendarBookingSteps.openBookingScreen()"
});
formatter.result({
  "duration": 42900,
  "status": "passed"
});
formatter.scenario({
  "line": 21,
  "name": "Запазване на час при зъболекар с заета дата",
  "description": "",
  "id": "валидиране-на-чaс-в-календар;запазване-на-час-при-зъболекар-с-заета-дата",
  "type": "scenario",
  "keyword": "Scenario"
});
formatter.step({
  "line": 22,
  "name": "Въведе \"gerity59@gmail.com\" е-поща",
  "keyword": "When "
});
formatter.step({
  "line": 23,
  "name": "избере дата \"2022-05-22\"",
  "keyword": "And "
});
formatter.step({
  "line": 24,
  "name": "избере час \"15:15\"",
  "keyword": "And "
});
formatter.step({
  "line": 25,
  "name": "и натисне бутона за запазване на час",
  "keyword": "And "
});
formatter.step({
  "line": 26,
  "name": "Вижда съобщение \"Часът е зает!\"",
  "keyword": "Then "
});
formatter.match({
  "arguments": [
    {
      "val": "gerity59@gmail.com",
      "offset": 8
    }
  ],
  "location": "CalendarBookingSteps.addEmail(String)"
});
formatter.result({
  "duration": 49700,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "2022-05-22",
      "offset": 13
    }
  ],
  "location": "CalendarBookingSteps.addDate(String)"
});
formatter.result({
  "duration": 52100,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "15:15",
      "offset": 12
    }
  ],
  "location": "CalendarBookingSteps.addHour(String)"
});
formatter.result({
  "duration": 51100,
  "status": "passed"
});
formatter.match({
  "location": "CalendarBookingSteps.clickReserveBtn()"
});
formatter.result({
  "duration": 172200,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "Часът е зает!",
      "offset": 17
    }
  ],
  "location": "CalendarBookingSteps.checkMessage(String)"
});
formatter.result({
  "duration": 75400,
  "status": "passed"
});
formatter.background({
  "line": 3,
  "name": "",
  "description": "",
  "type": "background",
  "keyword": "Background"
});
formatter.step({
  "line": 4,
  "name": "Потребителят отваря екрана за запазване на час",
  "keyword": "Given "
});
formatter.match({
  "location": "CalendarBookingSteps.openBookingScreen()"
});
formatter.result({
  "duration": 73300,
  "status": "passed"
});
formatter.scenario({
  "line": 28,
  "name": "Запазване на час при зъболекар с невалидна дата и час",
  "description": "",
  "id": "валидиране-на-чaс-в-календар;запазване-на-час-при-зъболекар-с-невалидна-дата-и-час",
  "type": "scenario",
  "keyword": "Scenario"
});
formatter.step({
  "line": 29,
  "name": "Въведе \"gerity59@gmail.com\" е-поща",
  "keyword": "When "
});
formatter.step({
  "line": 30,
  "name": "избере дата \"2233-02-31\"",
  "keyword": "And "
});
formatter.step({
  "line": 31,
  "name": "избере час \"10:15\"",
  "keyword": "And "
});
formatter.step({
  "line": 32,
  "name": "и натисне бутона за запазване на час",
  "keyword": "And "
});
formatter.step({
  "line": 33,
  "name": "Вижда съобщение \"Невалидни дата и час!\"",
  "keyword": "Then "
});
formatter.match({
  "arguments": [
    {
      "val": "gerity59@gmail.com",
      "offset": 8
    }
  ],
  "location": "CalendarBookingSteps.addEmail(String)"
});
formatter.result({
  "duration": 61200,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "2233-02-31",
      "offset": 13
    }
  ],
  "location": "CalendarBookingSteps.addDate(String)"
});
formatter.result({
  "duration": 61800,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "10:15",
      "offset": 12
    }
  ],
  "location": "CalendarBookingSteps.addHour(String)"
});
formatter.result({
  "duration": 56200,
  "status": "passed"
});
formatter.match({
  "location": "CalendarBookingSteps.clickReserveBtn()"
});
formatter.result({
  "duration": 226700,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "Невалидни дата и час!",
      "offset": 17
    }
  ],
  "location": "CalendarBookingSteps.checkMessage(String)"
});
formatter.result({
  "duration": 91000,
  "status": "passed"
});
formatter.background({
  "line": 3,
  "name": "",
  "description": "",
  "type": "background",
  "keyword": "Background"
});
formatter.step({
  "line": 4,
  "name": "Потребителят отваря екрана за запазване на час",
  "keyword": "Given "
});
formatter.match({
  "location": "CalendarBookingSteps.openBookingScreen()"
});
formatter.result({
  "duration": 57800,
  "status": "passed"
});
formatter.scenario({
  "line": 35,
  "name": "Запазване на час при зъболекар с празна дата",
  "description": "",
  "id": "валидиране-на-чaс-в-календар;запазване-на-час-при-зъболекар-с-празна-дата",
  "type": "scenario",
  "keyword": "Scenario"
});
formatter.step({
  "line": 36,
  "name": "Въведе \"gerity59@gmail.com\" е-поща",
  "keyword": "When "
});
formatter.step({
  "line": 37,
  "name": "и натисне бутона за запазване на час",
  "keyword": "And "
});
formatter.step({
  "line": 38,
  "name": "Вижда съобщение \"Неуспешно запазен час!\"",
  "keyword": "Then "
});
formatter.match({
  "arguments": [
    {
      "val": "gerity59@gmail.com",
      "offset": 8
    }
  ],
  "location": "CalendarBookingSteps.addEmail(String)"
});
formatter.result({
  "duration": 243200,
  "status": "passed"
});
formatter.match({
  "location": "CalendarBookingSteps.clickReserveBtn()"
});
formatter.result({
  "duration": 73300,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "Неуспешно запазен час!",
      "offset": 17
    }
  ],
  "location": "CalendarBookingSteps.checkMessage(String)"
});
formatter.result({
  "duration": 79200,
  "status": "passed"
});
});