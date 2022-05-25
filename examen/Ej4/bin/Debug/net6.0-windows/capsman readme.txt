Provisioning: Sirve para crear automáticamente los interfaces CAP
	Action = dynamic sirve para que cree dinámicamente los interfaces CAP
	HW. Supported modes = sirve para cotejar las radios de los APs con la configuración
	Master configuration = La configuración con la que se asocian los APs
	Name Format = prefix-identity es visual para que se vea en el listado el nombre del equipo y
				  la configuración que está usando.
	
CAP Configuraction: La configuración global con la que se asocian los CAPs
	Name = identificador
	SSID = nombre de la Wifi
	Hw. Retries = ni idea, poner 4
	Multicast Helper = full, sirve para mejorar el rendimiento del multicast
	
	En Channel, Datapath y Security seleccionaremos las configuraciones de esos
	apartados que ya tenemos hechas.

Channel: Sirve para agrupar radios/CAPs según el tipo de wifi
	Band: Banda de la wifi que se va a usar
	Frequency: Se puede especificar la misma frecuencia para todos o dejar que cada uno coja la
			   frecuencia que quiera. Igual con Extension Channel
			   
Datapath: Aquí usar siempre local forwarding
	Local Forwarding: X
	Client To Client Forwarding: X
	Así permite todo el forwarding
	
Security: Configuración de seguridad normal y corriente
	Authentication: WPA2-PSK
	Encryption: AES
	Passphrase: patata1234
	
			