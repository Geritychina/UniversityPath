package uni.fmi.models;
import java.util.*;


public class Calendar {

	 private Set<Date> dateHours;
	 private Set<User> patients;
	 private Set<BookHour> receptionist;
	 private Set<Employee> employee;

    /**
     * Default constructor
     */
    public Calendar() {
    }

    
 

    /**
     * @return
     */
    public Set<Date> getDateHours() {
    	if(dateHours == null) {
    		dateHours = new HashSet<Date>();
    	}
        return dateHours;
    }

    /**
     * @param datehours 
     * @return
     */
    public void setDateHours(Set<Date> datehours) {
       this.dateHours = datehours;
       
    }




	public Set<User> getPatients() {
		if(patients == null) {
			patients = new HashSet<User>();
		}
		return patients;
	}




	public void setPatients(Set<User> patients) {
		this.patients = patients;
	}




	public Set<BookHour> getReceptionist() {
		if(receptionist == null) {
			receptionist = new HashSet<BookHour>();
		}
		return receptionist;
	}




	public void setReceptionist(Set<BookHour> receptionist) {
		this.receptionist = receptionist;
	}




	public Set<Employee> getEmployee() {
		if(employee == null) {
			employee = new HashSet<Employee>();
		}
		return employee;
	}




	public void setEmployee(Set<Employee> employee) {
		this.employee = employee;
	}

}