





def Main():
	
	opt_list = []
	while True:
		#print menu here
		print '============='
		print "Menu Options"
		print '============='
		print ''
		opt_choice = int(raw_input("Make Your Selection: "))
		opt_choice -= 1
		opt_list[opt_choice]()
		
Main()
		
