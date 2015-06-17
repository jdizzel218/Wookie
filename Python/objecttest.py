
class Square(object):
	
	coordinates = []
	
	def __init__(self, side):
		self.side = side
			
	def area(self):
		A1 = (self.side ** 2)
		print "Area: %d" % A1
		return A1
		
	def perimiter(self):
		perm = self.side * 4
		print "Permimeter: %d" % perm
		return perm
		

class Triangle(Square):
	def __init__(self,side):
		self.side = side
		
		

tri = Triangle(10)
print tri.area()
print tri.perimiter()
"""def main():
	opt_list = [Square]
	
	while True:
		print "Menu Selection"
		print "1:Square"
		opt_choice = int(raw_input("Enter Selection: "))
		opt_choice -= 1
		opt_list[opt_choice]()
	



main()"""
	




		
		

