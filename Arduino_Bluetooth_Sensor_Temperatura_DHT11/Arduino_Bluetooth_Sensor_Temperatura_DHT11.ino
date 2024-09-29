#include <SoftwareSerial.h>
#include <DHT.h>

#define DHTPIN 3
#define DHTTYPE DHT11
DHT dht(DHTPIN, DHTTYPE);
String a;
byte rx = 10;
byte tx = 11;
SoftwareSerial bt(rx, tx);
float temperatura;

void setup() 
{
  Serial.begin(9600);
  bt.begin(9600);
  dht.begin();
}

void loop() 
{
  temperatura = dht.readTemperature();
  
  bt.println((int)round(temperatura));
  Serial.print("Temperatura: ");
  Serial.println((int)round(temperatura));
  
  delay(1000);
}
