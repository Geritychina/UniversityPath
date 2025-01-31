package uni.fmi.models;
import java.util.*;


public class Role {

	
	
	private String roleCode;
	private Set<User> users;
    /**
     * Default constructor
     */
    public Role() {
    }

   
  

    /**
     * @return
     */
    public String getRole() {
       return roleCode;
    }

    /**
     * @param role 
     * @return
     */
    public void setRole(String role) {
      this.roleCode = role;
        
    }

    /**
     * @return
     */
    public Set<User> getUsers() {
    	if (null == users) {
			users = new HashSet<>();
		}
		return users;
    }

    /**
     * @param users 
     * @return
     */
    public void setUsers(Set<User> users) {
        this.users = users;
       
    }




	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		result = prime * result + ((roleCode == null) ? 0 : roleCode.hashCode());
		result = prime * result + ((users == null) ? 0 : users.hashCode());
		return result;
	}




	@Override
	public boolean equals(Object obj) {
		if (this == obj) {
			return true;
		}
		if (obj == null) {
			return false;
		}
		if (getClass() != obj.getClass()) {
			return false;
		}
		Role other = (Role) obj;
		if (roleCode == null) {
			if (other.roleCode != null) {
				return false;
			}
		} else if (!roleCode.equals(other.roleCode)) {
			return false;
		}
		if (users == null) {
			if (other.users != null) {
				return false;
			}
		} else if (!users.equals(other.users)) {
			return false;
		}
		return true;
	}

}