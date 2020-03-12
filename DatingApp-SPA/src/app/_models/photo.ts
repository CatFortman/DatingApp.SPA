import { Tag } from './Tag';

export interface Photo {
  id: number;
  url: string;
  title: string;
  description: string;
  dateAdded: string;
  isMain: boolean;
  tags?: Tag[];
}
