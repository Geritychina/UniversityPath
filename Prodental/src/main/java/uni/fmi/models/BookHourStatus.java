package uni.fmi.models;
import java.util.*;

/**
 * 
 */
public class BookHourStatus {

	private Boolean isConfirmed;
    private Set<BookHour> bookinghours;
    /**
     * Default constructor
     */
    public BookHourStatus() {
    }
    
    

    /**
     * @return
     */
    public Boolean getIsConfirmed() {
        return isConfirmed;
    }

    /**
     * @param isConfirmed 
     * @return
     */
    public void setIsConfirmed(Boolean isConfirmed) {
        this.isConfirmed = isConfirmed;
    }

    /**
     * @return
     */
    public Set<BookHour> getBookHours() {
    	if(bookinghours == null) {
    		bookinghours = new HashSet<BookHour>();
    	}
       return bookinghours;
    }

    /**
     * @param bookhour 
     * @return
     */
    public void setBookHours(Set<BookHour> bookhour) {
        this.bookinghours = bookhour;
     
    }

}