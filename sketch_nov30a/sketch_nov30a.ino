/unsigned long last_time = 0;
// constants won't change. They're used here to set pin numbers:
const int buttonPin = 8;     // the number of the pushbutton pin
const int buttonPin2 = 7;
String Commands = "";
// variables will change:
int buttonState = 0;         // variable for reading the pushbutton status
int buttonState2 = 0;
void setup() {
  //START THE BAUD RATE
  Serial.begin(9600);
  
  // initialize the LED pin as an output:
  pinMode(LED_BUILTIN, OUTPUT);
  // initialize the pushbutton pin as an input:
  pinMode(buttonPin, INPUT);
  pinMode(buttonPin2, INPUT);
}

void loop() {
      Commands = "";
  // read the state of the pushbutton value:
  buttonState = digitalRead(buttonPin);
  buttonState2 = digitalRead(buttonPin2);
  if (buttonState == HIGH){
    Commands += "L,";
  }
  else{
    Commands += "W,";
  }
  if(buttonState2 == HIGH){
    Commands += "R";
  }
  else{
    Commands += "W";
  }
  if (millis() > last_time + 1000)
    {
    Serial.println(Commands);
    }
  // check if the pushbutton is pressed. If it is, the buttonState is HIGH:
 /* if (buttonState == HIGH) {
    // turn LED on:
    digitalWrite(LED_BUILTIN, HIGH);
  } else {
    // turn LED off:
    digitalWrite(LED_BUILTIN, LOW);
  }*/
}
