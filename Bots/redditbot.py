import praw







def main():
	
	topic = str(raw_input("What subreddit do you want to view? "))
	LIMIT = int(raw_input("How many posts do you want to see? "))
	user_agent = "Richard Whiskey"
	r = praw.Reddit( user_agent = user_agent)
	
	subreddit = r.get_subreddit(topic)
	
	for submission in subreddit.get_hot(limit = LIMIT):
		print "Title: %s\n" % submission.title
		print 			 submission.selftext
		print "Score: ", submission.score
		print ''
		print "-------------------------\n"
	
	return
	
main()
