package uni.fmi.models;
import java.util.*;


public class BookHour {

	 
	 private String name;
	 private String email;
	 private Date DateHour;
	 private User patient;
	 private Calendar hours;
	 private BookHourStatus status;
    /**
     * Default constructor
     */
    public BookHour() {
    }
    
    

    public BookHour(String name, String number, String email,Date date) {
    	this.name = name;
    	this.email = email;
    	this.DateHour = date;
    	BookHourStatus bhs = new BookHourStatus();
    	bhs.setIsConfirmed(true);
    	
    }

    /**
     * @return
     */
    public String getName() {
       return name;
    }

    /**
     * @param name 
     * @return
     */
    public void setName(String name) {
        this.name = name;
      
    }

    /**
     * @return
     */
    public String getEmail() {
        return email;
    }

    /**
     * @param email 
     * @return
     */
    public void setEmail(String email) {
        this.email = email;
      
    }

    /**
     * @param patient 
     * @return
     */
    public void setPatient(User patient) {
        this.patient = patient;
       
    }

    /**
     * @return
     */
    public User getPatient() {
        return patient;
    }

    /**
     * @return
     */
    public Date getHour() {
        return DateHour;
    }

    /**
     * @param dthr 
     * @return
     */
    public void setHour(Date dthr) {
       this.DateHour = dthr;
       
    }

    /**
     * @return
     */
    public BookHourStatus getStatus() {
        return status;
    }

    /**
     * @param status 
     * @return
     */
    public void setStatus(BookHourStatus status) {
    	this.status = status;
        
    }



	public Calendar getHours() {
		return hours;
	}



	public void setHours(Calendar hours) {
		this.hours = hours;
	}

	
}