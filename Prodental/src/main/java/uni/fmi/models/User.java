package uni.fmi.models;
import java.util.*;

/**
 * 
 */
public class User {

	  private String fullName;
	  private String password;
	  private Integer number;
	  private String email;
	  private Boolean isEmployee;
	  private Set<Role> roles;
	  private Set<Calendar> hours;
	  private Set<BookHour> bookedhour;
    /**
     * Default constructor
     */
    public User() {
    	
    }

    public User(final String username,  final String password) {
    	this.fullName = username;
    	this.password = password;
    	
    }

  

    /**
     * @return
     */
    public String getUsername() {
        return fullName;
    }

    /**
     * @param username 
     * @return
     */
    public void setUsername(String username) {
        this.fullName = username;
       
    }

    /**
     * @return
     */
    public String getPassword() {
        return password;
    }

    /**
     * @param pass 
     * @return
     */
    public void setPassword(String pass) {
        this.password = pass;
        
    }

    /**
     * @return
     */
    public Integer getPhoneNum() {
        return number;
    }

    /**
     * @param number
     */
    public void setPhoneNum(Integer number) {
        this.number = number;
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
     * @param isEmp 
     * @return
     */
    public void setEmployee(Boolean isEmp) {
        this.isEmployee = isEmp;
        
    }

    /**
     * @return
     */
    public Boolean getEmployeeStatus() {
        // TODO implement here
        return null;
    }




	public Set<Calendar> getHours() {
		if(null == hours) {
			hours = new HashSet<Calendar>();
		}
		return hours;
	}




	public void setHours(Set<Calendar> hours) {
		this.hours = hours;
	}




	public Set<BookHour> getBookedhour() {
		if(bookedhour == null) {
			bookedhour = new HashSet<BookHour>();
		}
		return bookedhour;
	}




	public void setBookedhour(Set<BookHour> bookedhour) {
		this.bookedhour = bookedhour;
	}




	public Set<Role> getRoles() {
		if (roles == null) {
			roles = new HashSet<>();
		}
		return null;
	}




	public void setRoles(Set<Role> roles) {
		if(roles != null) {
			this.roles = roles;
		}else {
			this.roles.clear();
		}
	}
	
	public Boolean getIsEmployee() {
    	return isEmployee;
    }
    
    public void setIsEmployee(Boolean isEmp) {
    	this.isEmployee=isEmp;
    }

}