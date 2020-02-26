int tasterWhite = 13;
int tasterBlue = 12;
int sensorWert = 0;
int tasterWhiteStatus = 0;
int tasterBlueStatus = 0;
int eingang = A0;

void setup()
{
  // Initalize the Serialport
  Serial.begin(9600);

  pinMode(tasterBlue, INPUT); 
  pinMode(tasterWhite, INPUT); 
  
 
}

void loop()
{
  
  delay(20);
  
  char array[3];
 
  
  tasterBlueStatus=digitalRead(tasterBlue);
  if(tasterBlueStatus == HIGH){
      //Serial.flush();
      //Serial.println("jump");
      array[0] = "jump";
  }

 
  tasterWhiteStatus=digitalRead(tasterWhite);
  if(tasterWhiteStatus == HIGH){
      //Serial.flush(); 
      //Serial.println(" forward");
      array[1] = "forward";
    
  }

    
    sensorWert = analogRead(eingang);
   
   
    if(sensorWert > 400 && sensorWert < 600) {  
            array[2] = " standStill";
    }
    else if(sensorWert > 600){  
            array[2] = " goLeft";
    }
    else if(sensorWert < 400){  
            array[2] = " goRight";
    }
     

    Serial.flush(); 
    Serial.println(array[0] + array [1] + array[2]);


   free(array);
  
}


 
