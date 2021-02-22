import { Menu } from './Menu';
import { Permission } from './Permission';
import { Website } from './Website';

export interface Member {
  id: number;
  username: string;
  token?: any;
  firstName?: any;
  middleNames?: any;
  lastName?: any;
  userType: string;
  department?: any;
  location?: any;
  email: string;
  phoneNumber: string;
  createdAt: string;
  updateAt: string;
  menus: Menu[];
  permissions: Permission[];
  websites: Website[];
  userHolidays: any[];
  userInOutTimes: any[];
  userLeaveApplications: any[];
}

