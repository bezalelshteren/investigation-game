# investigation game


interface Iagent בגלל שיש כמה סוגי סוכנים לא סגור על זה או אבסטרקט
מכיל
 string Rank 
 int SensorSlots
 string[] ListOfSensors
 string[] SensorHeNee
 void CounterattackBehavior();
    


    קלאס של simpleAgent שיורש את ה interface ומגדיר שם את גודל המערך לפי דרגת הסוכן 
    


    class sensor  קלאס סנסור גם לא סגור על זה 
    
   מכיל
     string name
     string type
     public bool activate()

     public class hearing_sensor :sensor    קלאס שיורש את סנסור ויהיה קצת שונה לפי הסוג
     


    public class inveestigation    קלאס שינהל את כל מה שיקרה כשאני מפעיל את activate 

   מכיל מתודות
    1 מעבירה את הרשימות מילון עם איזה שהוא בדיקה על הכמות
    2שיופעל בקונסטרקטור שמקבל את שתי המילונים ויעשה את ההשוואה



    Start
  │
  ▼
  interface Iagent

יצירת Agent (SimpleAgent):Iagent
  │
  ▼
  class sansor abctract

 Sensor haering :sensor
  │
  ▼
  מגדיר לפי rank את אורך הרשימה

הפעלת Investigation
  │
  ├──> המרה לרשימות => מילונים
  │
  ├──> השוואה בין מילונים
  │
  └──> בדיקת התאמה / תגובת Counterattack
  │
  ▼
End
