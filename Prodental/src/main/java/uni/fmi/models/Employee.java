package uni.fmi.models;
import java.util.*;


public class Employee {

	private String username;
    private String password;
    private Set<Calendar> hours;
    /**
     * Default constructor
     */
    public Employee() {
    }

    
    

    /**
     * @param name 
     * @param number 
     * @param email 
     * @return
     */
    
    
  
    
    
    
    public void BookVisit(String name, String number, String email,Date date) {
       
     BookHour newBookedHour = new BookHour(name,number,email,date);
    }

    /**
     * @return
     */
    public void SetFreeHours() {
        // TODO implement here
       
    }




	public String getUsername() {
		return username;
	}




	public void setUsername(String username) {
		this.username = username;
	}




	public String getPassword() {
		return password;
	}




	public void setPassword(String password) {
		this.password = password;
	}




	public Set<Calendar> getHours() {
		if(hours == null) {
			hours = new HashSet<Calendar>();
		}
		return hours;
	}




	public void setHours(Set<Calendar> hours) {
		this.hours = hours;
	}

}